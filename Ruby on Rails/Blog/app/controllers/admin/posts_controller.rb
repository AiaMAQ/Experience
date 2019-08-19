class Admin::PostsController < Admin::BaseController

  
  def index

    @posts = Post.all 

  end

  def new 
  
  @post = Post.new

  end

  def create
  
  @post = Post.new(post_params)
  if @post.save
     redirect_to admin_posts_path, notice: "Post was created sucessfully!"
    else
      render 'admin/posts/new'
    end

  end

  def edit
  
  @post = Post.find(params[:id])

  end


  def update
    @post = Post.find(params[:id])
    if @post.update post_params
      redirect_to admin_posts_path, notice: "The article was sucessfully"
    else
      render 'edit'
    end
  end

   def destroy
    @post = Post.find(params[:id])
    @post.destroy
    redirect_to admin_posts_path
  end

  def show
    @post = Post.find(params[:id])
  end

 


  protected 

  def post_params
    params.require(:post).permit(:title, :content)
  end

end


