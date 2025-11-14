using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1393 - .
/// </summary>
public class F1393 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GONUMB.
        /// </summary>
        public const string GONUMB = "GONUMB";

        /// <summary>
        /// GOSRVT.
        /// </summary>
        public const string GOSRVT = "GOSRVT";

        /// <summary>
        /// GOTHPC.
        /// </summary>
        public const string GOTHPC = "GOTHPC";

        /// <summary>
        /// GOMSTS.
        /// </summary>
        public const string GOMSTS = "GOMSTS";

        /// <summary>
        /// GOGPFS.
        /// </summary>
        public const string GOGPFS = "GOGPFS";

        /// <summary>
        /// GOGPTS.
        /// </summary>
        public const string GOGPTS = "GOGPTS";

        /// <summary>
        /// GOSRST.
        /// </summary>
        public const string GOSRST = "GOSRST";

        /// <summary>
        /// GOPRTS.
        /// </summary>
        public const string GOPRTS = "GOPRTS";

        /// <summary>
        /// GOTYPS.
        /// </summary>
        public const string GOTYPS = "GOTYPS";

        /// <summary>
        /// GOCTWO.
        /// </summary>
        public const string GOCTWO = "GOCTWO";

        /// <summary>
        /// GODSWO.
        /// </summary>
        public const string GODSWO = "GODSWO";

        /// <summary>
        /// GOAPRT.
        /// </summary>
        public const string GOAPRT = "GOAPRT";

        /// <summary>
        /// GOAPID.
        /// </summary>
        public const string GOAPID = "GOAPID";

        /// <summary>
        /// GOASID.
        /// </summary>
        public const string GOASID = "GOASID";

        /// <summary>
        /// GOMUSE.
        /// </summary>
        public const string GOMUSE = "GOMUSE";

        /// <summary>
        /// GOMPID.
        /// </summary>
        public const string GOMPID = "GOMPID";

        /// <summary>
        /// GOUPMJ.
        /// </summary>
        public const string GOUPMJ = "GOUPMJ";

        /// <summary>
        /// GOUPMT.
        /// </summary>
        public const string GOUPMT = "GOUPMT";

        /// <summary>
        /// GOSDYS.
        /// </summary>
        public const string GOSDYS = "GOSDYS";

        /// <summary>
        /// GOPSDM.
        /// </summary>
        public const string GOPSDM = "GOPSDM";

        /// <summary>
        /// GOPRFD.
        /// </summary>
        public const string GOPRFD = "GOPRFD";

        /// <summary>
        /// GOCOLD.
        /// </summary>
        public const string GOCOLD = "GOCOLD";

        /// <summary>
        /// GOCOPL.
        /// </summary>
        public const string GOCOPL = "GOCOPL";

        /// <summary>
        /// GODCTO.
        /// </summary>
        public const string GODCTO = "GODCTO";

        /// <summary>
        /// GOWOBP.
        /// </summary>
        public const string GOWOBP = "GOWOBP";

        /// <summary>
        /// GODEFOW.
        /// </summary>
        public const string GODEFOW = "GODEFOW";

        /// <summary>
        /// GODEFST.
        /// </summary>
        public const string GODEFST = "GODEFST";

        /// <summary>
        /// GOWSCHF.
        /// </summary>
        public const string GOWSCHF = "GOWSCHF";
    }

    /// <inheritdoc />
    public override string TableName => "F1393";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GONUMB", "GONUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("GOSRVT", "GOSRVT", JdeDataType.String, 16, true, true),
        new JdeField("GOTHPC", "GOTHPC", JdeDataType.Numeric),
        new JdeField("GOMSTS", "GOMSTS", JdeDataType.String, 4),
        new JdeField("GOGPFS", "GOGPFS", JdeDataType.String, 4),
        new JdeField("GOGPTS", "GOGPTS", JdeDataType.String, 4),
        new JdeField("GOSRST", "GOSRST", JdeDataType.String, 4),
        new JdeField("GOPRTS", "GOPRTS", JdeDataType.String, 2),
        new JdeField("GOTYPS", "GOTYPS", JdeDataType.String, 2),
        new JdeField("GOCTWO", "GOCTWO", JdeDataType.String, 2),
        new JdeField("GODSWO", "GODSWO", JdeDataType.String, 2),
        new JdeField("GOAPRT", "GOAPRT", JdeDataType.String, 6),
        new JdeField("GOAPID", "GOAPID", JdeDataType.String, 24),
        new JdeField("GOASID", "GOASID", JdeDataType.String, 50),
        new JdeField("GOMUSE", "GOMUSE", JdeDataType.String, 20),
        new JdeField("GOMPID", "GOMPID", JdeDataType.String, 20),
        new JdeField("GOUPMJ", "GOUPMJ", JdeDataType.Numeric),
        new JdeField("GOUPMT", "GOUPMT", JdeDataType.Numeric),
        new JdeField("GOSDYS", "GOSDYS", JdeDataType.Numeric),
        new JdeField("GOPSDM", "GOPSDM", JdeDataType.String, 2),
        new JdeField("GOPRFD", "GOPRFD", JdeDataType.String, 2),
        new JdeField("GOCOLD", "GOCOLD", JdeDataType.String, 2),
        new JdeField("GOCOPL", "GOCOPL", JdeDataType.String, 2),
        new JdeField("GODCTO", "GODCTO", JdeDataType.String, 4),
        new JdeField("GOWOBP", "GOWOBP", JdeDataType.String, 2),
        new JdeField("GODEFOW", "GODEFOW", JdeDataType.String, 2),
        new JdeField("GODEFST", "GODEFST", JdeDataType.String, 2),
        new JdeField("GOWSCHF", "GOWSCHF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1393_0", "Primary Key on GONUMB, GOSRVT", new[] { "GONUMB", "GOSRVT" }, isUnique: true, isPrimaryKey: true)
    };
}
