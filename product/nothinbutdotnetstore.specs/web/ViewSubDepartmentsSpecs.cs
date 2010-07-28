using System.Collections.Generic;
using Machine.Specifications;
using Machine.Specifications.DevelopWithPassion.Rhino;
using nothinbutdotnetstore.model;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.web.application.catalogbrowsing;
using nothinbutdotnetstore.web.core;
using Rhino.Mocks;

namespace nothinbutdotnetstore.specs.web
{
    public class ViewSubDepartmentsSpecs
    {
        public abstract class concern : Observes<ApplicationCommand, ViewSubDepartments>
        {
            
        }


        public class when_viewing_subdepartments_in_a_department : concern
        {
            Establish c = () =>
            {
                request = an<Request>();
                response_engine = the_dependency<ResponseEngine>();

                sub_departments_repository = the_dependency<DeparmentsRepository>();
                sub_departments = new List<Department>();

                sub_departments_repository.Stub(x => x.get_the_sub_departments_by("blah")).Return(sub_departments);

            };

            Because b = () =>
                sut.process(request);


            It should_render_the_list_of_sub_departments = () =>
                response_engine.received(x => x.display(sub_departments));

            static ResponseEngine response_engine;
            static IEnumerable<Department> sub_departments;
            static Request request;
            static DeparmentsRepository sub_departments_repository;

        
        }
    }


}