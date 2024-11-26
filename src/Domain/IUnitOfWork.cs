using FlexBook.Domain.Repositories;

namespace FlexBook.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        public IUserRepository Users { get; }
        public ICountryRepository CountryRepository { get;  }
        public IUnivesityRepository UnivesityRepository { get; }
        public IFacultyRepository FacultyRepository { get; }
        public ICouresRepository CouresRepository {  get; }
        public IDepartmentRepository DepartmentRepository { get; }
        public ISpecializationRepository SpecializationRepository { get; }
        public IInterestsListRepository InterestsListRepository { get; }
        public ITopicRepository TopicRepository { get; }
       public RoleRepositoryInterface RoleRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
        ISectionRepository SectionRepository { get; }
        ILessonRepository LessonRepository { get; }
        IQuizRepository QuizRepository { get; }
        IQuestionRepository QuestionRepository { get; }
        public IClassRepository ClassRepository { get; }
        public IInstructorCourseOverrideRepository InstructorCourseOverrideRepository { get; }
        public IInstructorCoursesRepository InstructorCoursesRepository { get; }
        public IStudentAvailableCoursesRepository StudentAvailableCoursesRepository { get; }

        public IClassRequestRepository ClassRequestRepository { get; }
        public IAccessCodeRepository AccessCodeRepository { get; }
        public ILessonPartRepository LessonPartRepository { get; }
        public IInteractiveElementRepository InteractiveElementRepository { get; }
        public IStudentSuccessStoryRepository StudentSuccessStoryRepository { get; }

        public IAuthorizingTeamMemberRepository AuthorizingTeamMemberRepository { get; }
        public IResearchRepository ResearchRepository { get; }
        public IAcademicIntegrityrRepository AcademicIntegrityrRepository { get; }
        public IInstructorSuccessStoryRepository InstructorSuccessStoryRepository { get; }
        public IStudentsGettingStartedArticleRepository StudentsGettingStartedArticleRepository { get; set; }
        public ITeachersGettingStartedArticleRepository TeachersGettingStartedArticleRepository  { get; set; }
        public IEvaluatingAdoptingArticleRepository EvaluatingAdoptingArticleRepository { get; set; }
        public IInstructorCommunityEntryRepository InstructorCommunityEntryRepository { get; set; }
        public IAboutUsSectionRepository AboutUsSectionRepository { get; set; }
        public ITestimonialRepository TestimonialRepository { get; set; }
        public IHomePageSectionRepository HomePageSectionRepository { get; set; }

        Task<int> CommitAsync(CancellationToken cancellationToken);
    }
}
