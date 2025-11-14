using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B8601 - .
/// </summary>
public class F76B8601 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FJDGJ.
        /// </summary>
        public const string FJDGJ = "FJDGJ";

        /// <summary>
        /// FJAN8.
        /// </summary>
        public const string FJAN8 = "FJAN8";

        /// <summary>
        /// FJTAX.
        /// </summary>
        public const string FJTAX = "FJTAX";

        /// <summary>
        /// FJTX2.
        /// </summary>
        public const string FJTX2 = "FJTX2";

        /// <summary>
        /// FJBMUN.
        /// </summary>
        public const string FJBMUN = "FJBMUN";

        /// <summary>
        /// FJMLNM.
        /// </summary>
        public const string FJMLNM = "FJMLNM";

        /// <summary>
        /// FJMLAD.
        /// </summary>
        public const string FJMLAD = "FJMLAD";

        /// <summary>
        /// FJNBHD.
        /// </summary>
        public const string FJNBHD = "FJNBHD";

        /// <summary>
        /// FJCTY1.
        /// </summary>
        public const string FJCTY1 = "FJCTY1";

        /// <summary>
        /// FJADDS.
        /// </summary>
        public const string FJADDS = "FJADDS";

        /// <summary>
        /// FJCTBR.
        /// </summary>
        public const string FJCTBR = "FJCTBR";

        /// <summary>
        /// FJADDZ.
        /// </summary>
        public const string FJADDZ = "FJADDZ";

        /// <summary>
        /// FJTAXC.
        /// </summary>
        public const string FJTAXC = "FJTAXC";

        /// <summary>
        /// FJRDOR.
        /// </summary>
        public const string FJRDOR = "FJRDOR";

        /// <summary>
        /// FJTORG.
        /// </summary>
        public const string FJTORG = "FJTORG";

        /// <summary>
        /// FJUSER.
        /// </summary>
        public const string FJUSER = "FJUSER";

        /// <summary>
        /// FJPID.
        /// </summary>
        public const string FJPID = "FJPID";

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
    public override string TableName => "F76B8601";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FJDGJ", "FJDGJ", JdeDataType.Numeric),
        new JdeField("FJAN8", "FJAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("FJTAX", "FJTAX", JdeDataType.String, 40),
        new JdeField("FJTX2", "FJTX2", JdeDataType.String, 40),
        new JdeField("FJBMUN", "FJBMUN", JdeDataType.String, 24),
        new JdeField("FJMLNM", "FJMLNM", JdeDataType.String, 80),
        new JdeField("FJMLAD", "FJMLAD", JdeDataType.String, 162),
        new JdeField("FJNBHD", "FJNBHD", JdeDataType.String, 40),
        new JdeField("FJCTY1", "FJCTY1", JdeDataType.String, 50),
        new JdeField("FJADDS", "FJADDS", JdeDataType.String, 6),
        new JdeField("FJCTBR", "FJCTBR", JdeDataType.String, 60),
        new JdeField("FJADDZ", "FJADDZ", JdeDataType.String, 24),
        new JdeField("FJTAXC", "FJTAXC", JdeDataType.String, 2),
        new JdeField("FJRDOR", "FJRDOR", JdeDataType.String, 2),
        new JdeField("FJTORG", "FJTORG", JdeDataType.String, 20),
        new JdeField("FJUSER", "FJUSER", JdeDataType.String, 20),
        new JdeField("FJPID", "FJPID", JdeDataType.String, 20),
        new JdeField("FJJOBN", "FJJOBN", JdeDataType.String, 20),
        new JdeField("FJUPMJ", "FJUPMJ", JdeDataType.Numeric),
        new JdeField("FJUPMT", "FJUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B8601_0", "Primary Key on FJAN8", new[] { "FJAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
