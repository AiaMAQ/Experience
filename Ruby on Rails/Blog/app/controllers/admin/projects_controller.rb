class Admin::ProjectsController < Admin::BaseController



def index

    @projects = Project.all 

  end

  def new 
  
  @project = Project.new

  end

  def create
  
  @project = Project.new(project_params)
  if @project.save
     redirect_to admin_project_path, notice: "Project was created sucessfully!"
    else
      render 'admin/projects/new'
    end

  end

   def edit
  
  @project = Project.find(params[:id])

  end


  def update
    @project = Project.find(params[:id])
    if @project.update project_params
      redirect_to admin_projects_path, notice: "The article was sucessfully"
    else
      render 'edit'
    end
  end

   def destroy
    @project = Project.find(params[:id])
    @project.destroy
    redirect_to admin_projects_path
  end

  def show
    @project = Project.find(params[:id])
  end



  protected 

  def project_params
    params.require(:project).permit(:title, :description, :link)
  end

end
