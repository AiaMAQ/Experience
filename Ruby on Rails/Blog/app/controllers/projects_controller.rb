class ProjectsController < ApplicationController

  before_action :authenticate_user!
 
  def index
    @projects = current_user.projects.order("created_at desc")
  end

  def new
    @project = Project.new
  end

  def create
    @project = Project.new project_params
    @project.user = current_user
    if @project.save
      redirect_to @project, notice: "Project was created sucessfully!"
    else
      render 'new'
    end
  end

  def show
    project
  end

  def edit
    @project = current_user.projects.find(params[:id])
  end

  def update
    if project.update project_params
      redirect_to @project, notice: "Project has been updated and saved!"
    else
      render 'edit'
    end

  end

  def destroy
    project.destroy
    redirect_to projects_path
  end

  

  private

  def project
    @project ||= current_user.projects.find(params[:id])
  end

  def project_params
    params.require(:project).permit(:title, :description, :link)
  end

end
