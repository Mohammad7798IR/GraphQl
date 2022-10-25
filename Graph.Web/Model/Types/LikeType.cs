namespace Graph.Web.Model.Types
{
        public class LikeType : ObjectType<Like>
        {
                protected override void Configure(IObjectTypeDescriptor<Like> descriptor)
                {
                        descriptor.Field(op => op.UserId)
                                .Type<StringType>();

                        descriptor.Field(op => op.User)
                                .Type<UserType>();

                        descriptor.Field(op => op.CreationDate)
                                .Type<DateType>();

                        descriptor.Field(op => op.ModificationDate)
                                .Type<DateType>();

                        descriptor.Field(op => op.PostId)
                                .Type<StringType>();

                        descriptor.Field(op => op.CommentId)
                                .Type<StringType>();

                        //descriptor.Field(op => op.Comment)
                        //        .Type<ObjectType<Comment>>();

                        //descriptor.Field(op => op.Post)
                        //        .Type<ObjectType<Post>>();

                        descriptor.Field(op => op.Id)
                               .Type<StringType>();








                }
        }
}
