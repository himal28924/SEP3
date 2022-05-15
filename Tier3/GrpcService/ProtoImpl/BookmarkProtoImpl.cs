﻿
using Entities.Contracts;
using Grpc.Core;
using GRPCService.ProtoImpl.Util;

namespace GRPCService.ProtoImpl;

public class BookmarkProtoImpl : Bookmark.BookmarkBase
{
    private IBookmarkService _bookmarkService;

    public BookmarkProtoImpl(IBookmarkService _bookmarkService)
    {
        this._bookmarkService = _bookmarkService;
    }

    public override async Task<EmptyBookMark> AddBoomark(BookmarkObj request, ServerCallContext context)
    {
        Entities.Models.Bookmark local = ConvertGRPC.ConvertBookmarkObjToBookmark(request);
        await _bookmarkService.AddBookmark(local);
        return new EmptyBookMark();
    }

    public override async Task<EmptyBookMark> RemoveBookmark(StringAndIntegerBookmark request,ServerCallContext context)
    {
        string username = request.String;
        int postId = request.Current;
        Entities.Models.Bookmark ret= await _bookmarkService.RemoveBookmark(postId,username);
        return new EmptyBookMark();
    }

    public override async Task<ListOfPostsForBooking> GetListOfPosts(UserForBookMark request, ServerCallContext context)
    {
        string username = request.Username;
        List<Entities.Models.Post> list = await _bookmarkService.getListOfBookedElements(username);
        return ConvertGRPC.ConvertListPostToObjBooking(list);
    }
}