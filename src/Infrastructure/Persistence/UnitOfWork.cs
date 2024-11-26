using FlexBook.Domain;
using FlexBook.Domain.Repositories;
using FlexBook.Infrastructure.Persistence.Repositories;

namespace FlexBook.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FlexBookDbContext FlexBookDbContext;

        public IUserRepository Users { get; }
        public ICountryRepository CountryRepository { get; set; }
        public IUnivesityRepository UnivesityRepository { get; set; }
        public IDepartmentRepository DepartmentRepository { get; set; }
        public ISpecializationRepository SpecializationRepository { get; set; }

        public IFacultyRepository FacultyRepository { get; set; }
        public ICouresRepository CouresRepository { get; set; }
        public ICategoryRepository CategoryRepository { get; set; }
        // Correctly implement these properties
        public ISectionRepository SectionRepository { get; }
        public ILessonRepository LessonRepository { get; }
        public IQuizRepository QuizRepository { get; }
        public IQuestionRepository QuestionRepository { get; }

        public IInterestsListRepository InterestsListRepository { get; set; }
        public ITopicRepository TopicRepository { get; set; }
        public IClassRepository ClassRepository { get; set; }
        public IInstructorCourseOverrideRepository InstructorCourseOverrideRepository { get; set; }
        public IInstructorCoursesRepository InstructorCoursesRepository { get; set; }
        public IStudentAvailableCoursesRepository StudentAvailableCoursesRepository { get; set; }

        public IClassRequestRepository ClassRequestRepository { get; set; }
        public IAccessCodeRepository AccessCodeRepository { get; set; }
        public ILessonPartRepository LessonPartRepository { get; set; }
        public IInteractiveElementRepository InteractiveElementRepository { get; set; }
        public IStudentSuccessStoryRepository StudentSuccessStoryRepository { get; set; }
        public IAuthorizingTeamMemberRepository AuthorizingTeamMemberRepository { get; }
        public IResearchRepository ResearchRepository { get; }
        public IAcademicIntegrityrRepository AcademicIntegrityrRepository { get; }
        public IInstructorSuccessStoryRepository InstructorSuccessStoryRepository { get; set; }
        public IStudentsGettingStartedArticleRepository StudentsGettingStartedArticleRepository { get; set; }
        public ITeachersGettingStartedArticleRepository TeachersGettingStartedArticleRepository { get; set; }
        public IInstructorCommunityEntryRepository InstructorCommunityEntryRepository { get; set; }

        public IEvaluatingAdoptingArticleRepository EvaluatingAdoptingArticleRepository { get; set; }
        public RoleRepositoryInterface RoleRepository { get; set; }  // This fixes the missing property
         public IAboutUsSectionRepository AboutUsSectionRepository { get; set; }
        public ITestimonialRepository TestimonialRepository { get; set; }
        public IHomePageSectionRepository HomePageSectionRepository { get; set; }

        private bool _disposed = false;

        public UnitOfWork(FlexBookDbContext _context,
                           ISpecializationRepository specializationRepository,
                          IUserRepository users,
                          ICountryRepository countryRepository,
                          IUnivesityRepository univesityRepository,
                          IFacultyRepository facultyRepository,
                          IDepartmentRepository departmentRepository,
                          ICouresRepository couresRepository,
                          ITopicRepository topicrepository,
                        IClassRepository classRepository,
                        IInstructorCourseOverrideRepository instructorCourseOverrideRepository,
             IInstructorCoursesRepository instructorCoursesRepository,
                          IStudentAvailableCoursesRepository studentAvailableCoursesRepository,

             IClassRequestRepository classRequestRepository,
             IAccessCodeRepository accessCodeRepository,
                          IInterestsListRepository interestsListRepository,
                          RoleRepositoryInterface roleRepository,
                          ICategoryRepository categoryRepository,
                       ISectionRepository sectionRepository,
            ILessonRepository lessonRepository,
            IQuizRepository quizRepository,
            IQuestionRepository questionRepository,

                        ILessonPartRepository lessonPartRepository,
            IInteractiveElementRepository interactiveElementRepository,
                        IStudentSuccessStoryRepository studentSuccessStoryRepository
,
                        IAuthorizingTeamMemberRepository authorizingTeamMemberRepository
            ,
                        IResearchRepository researchRepository,

                        IAcademicIntegrityrRepository academicIntegrityrRepository,

            IInstructorSuccessStoryRepository instructorSuccessStoryRepository,
            IStudentsGettingStartedArticleRepository studentsGettingStartedArticleRepository
,
            ITeachersGettingStartedArticleRepository teachersGettingStartedArticleRepository
,

            IEvaluatingAdoptingArticleRepository evaluatingAdoptingArticleRepository,

              IInstructorCommunityEntryRepository instructorCommunityEntryRepository,
            IAboutUsSectionRepository aboutUsSectionRepository,
            ITestimonialRepository testimonialRepository,
                     IHomePageSectionRepository homePageSectionRepository 












































                          )
        {
            FlexBookDbContext = _context;
            Users = users;
            CountryRepository = countryRepository;
            UnivesityRepository = univesityRepository;
            DepartmentRepository = departmentRepository;
            FacultyRepository = facultyRepository;
            CouresRepository = couresRepository;
            InterestsListRepository = interestsListRepository;
            TopicRepository = topicrepository;
            ClassRepository = classRepository;
            RoleRepository = roleRepository;  // Assign the RoleRepository correctly
            CategoryRepository = categoryRepository;
            SectionRepository = sectionRepository; // Assign the SectionRepository correctly
            LessonRepository = lessonRepository; // Assign the LessonRepository correctly
            QuizRepository = quizRepository; // Assign the QuizRepository correctly
            QuestionRepository = questionRepository; // Assign the QuestionRepository correctly
            SpecializationRepository = specializationRepository;
            InstructorCourseOverrideRepository = instructorCourseOverrideRepository;
            InstructorCoursesRepository = instructorCoursesRepository;
            StudentAvailableCoursesRepository = studentAvailableCoursesRepository;
            ClassRequestRepository = classRequestRepository;
            AccessCodeRepository = accessCodeRepository;
            LessonPartRepository = lessonPartRepository;
            InteractiveElementRepository = interactiveElementRepository;
            StudentSuccessStoryRepository = studentSuccessStoryRepository;
            AuthorizingTeamMemberRepository = authorizingTeamMemberRepository;
            ResearchRepository = researchRepository;
            AcademicIntegrityrRepository = academicIntegrityrRepository;
            InstructorSuccessStoryRepository = instructorSuccessStoryRepository;
            StudentsGettingStartedArticleRepository = studentsGettingStartedArticleRepository;
            TeachersGettingStartedArticleRepository = teachersGettingStartedArticleRepository;
            EvaluatingAdoptingArticleRepository = evaluatingAdoptingArticleRepository;
            InstructorCommunityEntryRepository = instructorCommunityEntryRepository;
            AboutUsSectionRepository= aboutUsSectionRepository;
            TestimonialRepository= testimonialRepository;   
            HomePageSectionRepository= homePageSectionRepository;
        }

        public async Task<int> CommitAsync(CancellationToken cancellationToken)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(this.GetType().FullName);
            }

            return await FlexBookDbContext.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing && FlexBookDbContext != null)
            {
                FlexBookDbContext.Dispose();
            }

            _disposed = true;
        }
    }
}
