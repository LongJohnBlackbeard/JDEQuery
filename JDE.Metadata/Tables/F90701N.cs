using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90701N - .
/// </summary>
public class F90701N : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EDFRMREL.
        /// </summary>
        public const string EDFRMREL = "EDFRMREL";

        /// <summary>
        /// EDTHRREL.
        /// </summary>
        public const string EDTHRREL = "EDTHRREL";

        /// <summary>
        /// EDEVNTNAME.
        /// </summary>
        public const string EDEVNTNAME = "EDEVNTNAME";

        /// <summary>
        /// EDEVNTDESC.
        /// </summary>
        public const string EDEVNTDESC = "EDEVNTDESC";

        /// <summary>
        /// EDEVNTTYPE.
        /// </summary>
        public const string EDEVNTTYPE = "EDEVNTTYPE";

        /// <summary>
        /// EDEVNTAGG.
        /// </summary>
        public const string EDEVNTAGG = "EDEVNTAGG";

        /// <summary>
        /// EDEVNTSTATUS.
        /// </summary>
        public const string EDEVNTSTATUS = "EDEVNTSTATUS";

        /// <summary>
        /// EDEVNTDEL.
        /// </summary>
        public const string EDEVNTDEL = "EDEVNTDEL";

        /// <summary>
        /// EDDTOT.
        /// </summary>
        public const string EDDTOT = "EDDTOT";

        /// <summary>
        /// EDEVNTDS.
        /// </summary>
        public const string EDEVNTDS = "EDEVNTDS";

        /// <summary>
        /// EDEVNTDSD.
        /// </summary>
        public const string EDEVNTDSD = "EDEVNTDSD";

        /// <summary>
        /// EDSY.
        /// </summary>
        public const string EDSY = "EDSY";

        /// <summary>
        /// EDEVNTCONTXT.
        /// </summary>
        public const string EDEVNTCONTXT = "EDEVNTCONTXT";

        /// <summary>
        /// EDEVNTSCOPE.
        /// </summary>
        public const string EDEVNTSCOPE = "EDEVNTSCOPE";

        /// <summary>
        /// EDOBNM.
        /// </summary>
        public const string EDOBNM = "EDOBNM";

        /// <summary>
        /// EDDL01.
        /// </summary>
        public const string EDDL01 = "EDDL01";

        /// <summary>
        /// EDFUTUSEBLOB.
        /// </summary>
        public const string EDFUTUSEBLOB = "EDFUTUSEBLOB";

        /// <summary>
        /// EDFUTUSE01.
        /// </summary>
        public const string EDFUTUSE01 = "EDFUTUSE01";

        /// <summary>
        /// EDFUTUSE03.
        /// </summary>
        public const string EDFUTUSE03 = "EDFUTUSE03";

        /// <summary>
        /// EDFUTUSE04.
        /// </summary>
        public const string EDFUTUSE04 = "EDFUTUSE04";

        /// <summary>
        /// EDUPMJ.
        /// </summary>
        public const string EDUPMJ = "EDUPMJ";

        /// <summary>
        /// EDUPMT.
        /// </summary>
        public const string EDUPMT = "EDUPMT";

        /// <summary>
        /// EDPID.
        /// </summary>
        public const string EDPID = "EDPID";

        /// <summary>
        /// EDUSER.
        /// </summary>
        public const string EDUSER = "EDUSER";

        /// <summary>
        /// EDJOBN.
        /// </summary>
        public const string EDJOBN = "EDJOBN";

        /// <summary>
        /// EDCHGF.
        /// </summary>
        public const string EDCHGF = "EDCHGF";
    }

    /// <inheritdoc />
    public override string TableName => "F90701N";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDFRMREL", "EDFRMREL", JdeDataType.String, 20, true, true),
        new JdeField("EDTHRREL", "EDTHRREL", JdeDataType.String, 20, true, true),
        new JdeField("EDEVNTNAME", "EDEVNTNAME", JdeDataType.String, 20, true, true),
        new JdeField("EDEVNTDESC", "EDEVNTDESC", JdeDataType.String, 60),
        new JdeField("EDEVNTTYPE", "EDEVNTTYPE", JdeDataType.String, 10),
        new JdeField("EDEVNTAGG", "EDEVNTAGG", JdeDataType.String, 20),
        new JdeField("EDEVNTSTATUS", "EDEVNTSTATUS", JdeDataType.String, 2),
        new JdeField("EDEVNTDEL", "EDEVNTDEL", JdeDataType.String, 2),
        new JdeField("EDDTOT", "EDDTOT", JdeDataType.Numeric),
        new JdeField("EDEVNTDS", "EDEVNTDS", JdeDataType.String, 20),
        new JdeField("EDEVNTDSD", "EDEVNTDSD", JdeDataType.String, 60),
        new JdeField("EDSY", "EDSY", JdeDataType.String, 8),
        new JdeField("EDEVNTCONTXT", "EDEVNTCONTXT", JdeDataType.String, 2),
        new JdeField("EDEVNTSCOPE", "EDEVNTSCOPE", JdeDataType.String, 60),
        new JdeField("EDOBNM", "EDOBNM", JdeDataType.String, 20),
        new JdeField("EDDL01", "EDDL01", JdeDataType.String, 60),
        new JdeField("EDFUTUSEBLOB", "EDFUTUSEBLOB", JdeDataType.String),
        new JdeField("EDFUTUSE01", "EDFUTUSE01", JdeDataType.String, 2),
        new JdeField("EDFUTUSE03", "EDFUTUSE03", JdeDataType.String, 40),
        new JdeField("EDFUTUSE04", "EDFUTUSE04", JdeDataType.Numeric),
        new JdeField("EDUPMJ", "EDUPMJ", JdeDataType.Numeric),
        new JdeField("EDUPMT", "EDUPMT", JdeDataType.Numeric),
        new JdeField("EDPID", "EDPID", JdeDataType.String, 20),
        new JdeField("EDUSER", "EDUSER", JdeDataType.String, 20),
        new JdeField("EDJOBN", "EDJOBN", JdeDataType.String, 20),
        new JdeField("EDCHGF", "EDCHGF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90701N_0", "Primary Key on EDFRMREL, EDTHRREL, EDEVNTNAME", new[] { "EDFRMREL", "EDTHRREL", "EDEVNTNAME" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90701N_2", "Index on EDEVNTTYPE, EDEVNTNAME", new[] { "EDEVNTTYPE", "EDEVNTNAME" })
    };
}
