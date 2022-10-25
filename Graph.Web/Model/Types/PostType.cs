namespace Graph.Web.Model.Types
{
        public class PostType : ObjectType<Post>
        {
                protected override void Configure(IObjectTypeDescriptor<Post> descriptor)
                {
                        descriptor.Field(op => op.Title)
                                .Type<StringType>();

                        descriptor.Field(op => op.Text)
                                .Type<StringType>();

                        descriptor.Field(op => op.UserId)
                                .Type<StringType>();

                        descriptor.Field(op => op.User)
                                .Type<ObjectType<User>>();

                        descriptor.Field(op => op.UserId)
                                .Type<LongType>();

                        descriptor.Field(op => op.PostLikes)
                                .Type<LikeType>();

                        descriptor.Field(op => op.PostComments)
                                .Type<CommentType>();

                        descriptor.Field(op => op.CreationDate)
                                .Type<DateType>();

                        descriptor.Field(op => op.ModificationDate)
                                .Type<DateType>();

                        descriptor.Field(op => op.Id)
                               .Type<StringType>();









                }
        }
}
