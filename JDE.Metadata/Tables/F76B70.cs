using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B70 - .
/// </summary>
public class F76B70 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FJUPDJ.
        /// </summary>
        public const string FJUPDJ = "FJUPDJ";

        /// <summary>
        /// FJAT1.
        /// </summary>
        public const string FJAT1 = "FJAT1";

        /// <summary>
        /// FJAN8.
        /// </summary>
        public const string FJAN8 = "FJAN8";

        /// <summary>
        /// FJTAXC.
        /// </summary>
        public const string FJTAXC = "FJTAXC";

        /// <summary>
        /// FJTAX.
        /// </summary>
        public const string FJTAX = "FJTAX";

        /// <summary>
        /// FJTAXS.
        /// </summary>
        public const string FJTAXS = "FJTAXS";

        /// <summary>
        /// FJBMUN.
        /// </summary>
        public const string FJBMUN = "FJBMUN";

        /// <summary>
        /// FJALPH.
        /// </summary>
        public const string FJALPH = "FJALPH";

        /// <summary>
        /// FJALTC.
        /// </summary>
        public const string FJALTC = "FJALTC";

        /// <summary>
        /// FJBREND.
        /// </summary>
        public const string FJBREND = "FJBREND";

        /// <summary>
        /// FJBRENR.
        /// </summary>
        public const string FJBRENR = "FJBRENR";

        /// <summary>
        /// FJCOUN.
        /// </summary>
        public const string FJCOUN = "FJCOUN";

        /// <summary>
        /// FJCTY1.
        /// </summary>
        public const string FJCTY1 = "FJCTY1";

        /// <summary>
        /// FJADDS.
        /// </summary>
        public const string FJADDS = "FJADDS";

        /// <summary>
        /// FJADDZ.
        /// </summary>
        public const string FJADDZ = "FJADDZ";

        /// <summary>
        /// FJUSER.
        /// </summary>
        public const string FJUSER = "FJUSER";

        /// <summary>
        /// FJEAP.
        /// </summary>
        public const string FJEAP = "FJEAP";

        /// <summary>
        /// FJJOBN.
        /// </summary>
        public const string FJJOBN = "FJJOBN";

        /// <summary>
        /// FJUPMJ.
        /// </summary>
        public const string FJUPMJ = "FJUPMJ";

        /// <summary>
        /// FJUPMT.
        /// </summary>
        public const string FJUPMT = "FJUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B70";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FJUPDJ", "FJUPDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("FJAT1", "FJAT1", JdeDataType.String, 6, true, true),
        new JdeField("FJAN8", "FJAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("FJTAXC", "FJTAXC", JdeDataType.String, 2),
        new JdeField("FJTAX", "FJTAX", JdeDataType.String, 40),
        new JdeField("FJTAXS", "FJTAXS", JdeDataType.String, 40),
        new JdeField("FJBMUN", "FJBMUN", JdeDataType.String, 24),
        new JdeField("FJALPH", "FJALPH", JdeDataType.String, 80),
        new JdeField("FJALTC", "FJALTC", JdeDataType.String, 80),
        new JdeField("FJBREND", "FJBREND", JdeDataType.String, 162),
        new JdeField("FJBRENR", "FJBRENR", JdeDataType.String, 24),
        new JdeField("FJCOUN", "FJCOUN", JdeDataType.String, 50),
        new JdeField("FJCTY1", "FJCTY1", JdeDataType.String, 50),
        new JdeField("FJADDS", "FJADDS", JdeDataType.String, 6),
        new JdeField("FJADDZ", "FJADDZ", JdeDataType.String, 24),
        new JdeField("FJUSER", "FJUSER", JdeDataType.String, 20),
        new JdeField("FJEAP", "FJEAP", JdeDataType.String, 20),
        new JdeField("FJJOBN", "FJJOBN", JdeDataType.String, 20),
        new JdeField("FJUPMJ", "FJUPMJ", JdeDataType.Numeric),
        new JdeField("FJUPMT", "FJUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B70_0", "Primary Key on FJAT1, FJAN8, FJUPDJ", new[] { "FJAT1", "FJAN8", "FJUPDJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B70_2", "Index on FJAN8, FJAT1", new[] { "FJAN8", "FJAT1" })
    };
}
