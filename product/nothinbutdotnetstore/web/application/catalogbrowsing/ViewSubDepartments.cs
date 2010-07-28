using System;
using System.Collections.Generic;
using nothinbutdotnetstore.model;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application.catalogbrowsing
{
    public class ViewSubDepartments : ApplicationCommand
    {
        DeparmentsRepository deparments_repository;
        ResponseEngine response_engine;

        public ViewSubDepartments(DeparmentsRepository deparments_repository, ResponseEngine response_engine)
        {
            this.deparments_repository = deparments_repository;
            this.response_engine = response_engine;
        }

        public void process(Request request)
        {
            string department_name = request.get_parameter("department_name");
            response_engine.display(deparments_repository.get_the_sub_departments_by(department_name));

        }

 
    }
}