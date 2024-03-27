using ApiBasic.ApplicationServices.VideoModule.Abstract;
using ApiBasic.ApplicationServices.VideoModule.Dtos;
using ApiBasic.Domain;
using ApiBasic.Infrastructure;
using ApiBasic.Shared.Exceptions;
using ApiBasic.Shared.Shared;
using Microsoft.EntityFrameworkCore;

namespace ApiBasic.ApplicationServices.VideoModule.Implements
{
    public class VideoServices : IVideoServices
    {
        private AnimeAppContext _dbcontext;

        public VideoServices(AnimeAppContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Create(CreateVideoDto input)
        {
            _dbcontext.Videos.Add(
                new Video
                {
                    NameVideos = input.NameVideos,
                    ThoiDiemTao = input.ThoiDiemTao,
                    Time = input.Time,
                    AvatarVideoUrl = input.AvatarVideoUrl,
                    UrlVideo = input.UrlVideo,
                    VideoId = input.VideoId,
                }
            );
            _dbcontext.SaveChanges();
        }

        public void Delete(int VideoId)
        {
            var video =
                _dbcontext.Videos.FirstOrDefault(v => v.Id == VideoId)
                ?? throw new UserFriendlyExceptions("Video không tìm thấy");
            _dbcontext.Remove(video);
            _dbcontext.SaveChanges();
        }

        public PageResultDto<List<FindVideoDto>> GetAll(FilterDto input)
        {
            throw new NotImplementedException();
        }

        public void Update(UpdateVideoDto input)
        {
            var video =
                _dbcontext.Videos.FirstOrDefault(v => v.Id == input.VideoId)
                ?? throw new UserFriendlyExceptions("Video không tìm thấy");
            video.UrlVideo = input.UrlVideo;
            video.AvatarVideoUrl = input.AvatarVideoUrl;
            video.NameVideos = input.NameVideos;
            video.ThoiDiemTao = input.ThoiDiemTao;
            video.UrlVideo = input.UrlVideo;
            video.Time = input.Time;
            _dbcontext.SaveChanges();
        }
    }
}
