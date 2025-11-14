using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P411Z - .
/// </summary>
public class F74P411Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// V1EDUS.
        /// </summary>
        public const string V1EDUS = "V1EDUS";

        /// <summary>
        /// V1EDBT.
        /// </summary>
        public const string V1EDBT = "V1EDBT";

        /// <summary>
        /// V1EDTN.
        /// </summary>
        public const string V1EDTN = "V1EDTN";

        /// <summary>
        /// V1OKC.
        /// </summary>
        public const string V1OKC = "V1OKC";

        /// <summary>
        /// V1ODOC.
        /// </summary>
        public const string V1ODOC = "V1ODOC";

        /// <summary>
        /// V1ODCT.
        /// </summary>
        public const string V1ODCT = "V1ODCT";

        /// <summary>
        /// V1AN8R.
        /// </summary>
        public const string V1AN8R = "V1AN8R";

        /// <summary>
        /// V1IVD.
        /// </summary>
        public const string V1IVD = "V1IVD";

        /// <summary>
        /// V1P74TLDJ.
        /// </summary>
        public const string V1P74TLDJ = "V1P74TLDJ";

        /// <summary>
        /// V1URCD.
        /// </summary>
        public const string V1URCD = "V1URCD";

        /// <summary>
        /// V1URDT.
        /// </summary>
        public const string V1URDT = "V1URDT";

        /// <summary>
        /// V1URAT.
        /// </summary>
        public const string V1URAT = "V1URAT";

        /// <summary>
        /// V1URAB.
        /// </summary>
        public const string V1URAB = "V1URAB";

        /// <summary>
        /// V1URRF.
        /// </summary>
        public const string V1URRF = "V1URRF";

        /// <summary>
        /// V1FUTMN1.
        /// </summary>
        public const string V1FUTMN1 = "V1FUTMN1";

        /// <summary>
        /// V1FUTMN2.
        /// </summary>
        public const string V1FUTMN2 = "V1FUTMN2";

        /// <summary>
        /// V1FUTMN3.
        /// </summary>
        public const string V1FUTMN3 = "V1FUTMN3";

        /// <summary>
        /// V1FUTSTG1.
        /// </summary>
        public const string V1FUTSTG1 = "V1FUTSTG1";

        /// <summary>
        /// V1FUTSTG2.
        /// </summary>
        public const string V1FUTSTG2 = "V1FUTSTG2";

        /// <summary>
        /// V1FUTSTG3.
        /// </summary>
        public const string V1FUTSTG3 = "V1FUTSTG3";

        /// <summary>
        /// V1FUTDJ1.
        /// </summary>
        public const string V1FUTDJ1 = "V1FUTDJ1";

        /// <summary>
        /// V1FUTDJ2.
        /// </summary>
        public const string V1FUTDJ2 = "V1FUTDJ2";

        /// <summary>
        /// V1FUTDJ3.
        /// </summary>
        public const string V1FUTDJ3 = "V1FUTDJ3";

        /// <summary>
        /// V1FUTCHR1.
        /// </summary>
        public const string V1FUTCHR1 = "V1FUTCHR1";

        /// <summary>
        /// V1FUTCHR2.
        /// </summary>
        public const string V1FUTCHR2 = "V1FUTCHR2";

        /// <summary>
        /// V1FUTCHR3.
        /// </summary>
        public const string V1FUTCHR3 = "V1FUTCHR3";

        /// <summary>
        /// V1USER.
        /// </summary>
        public const string V1USER = "V1USER";

        /// <summary>
        /// V1PID.
        /// </summary>
        public const string V1PID = "V1PID";

        /// <summary>
        /// V1JOBN.
        /// </summary>
        public const string V1JOBN = "V1JOBN";

        /// <summary>
        /// V1UPMJ.
        /// </summary>
        public const string V1UPMJ = "V1UPMJ";

        /// <summary>
        /// V1UPMT.
        /// </summary>
        public const string V1UPMT = "V1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74P411Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("V1EDUS", "V1EDUS", JdeDataType.String, 20, true, true),
        new JdeField("V1EDBT", "V1EDBT", JdeDataType.String, 30, true, true),
        new JdeField("V1EDTN", "V1EDTN", JdeDataType.String, 44, true, true),
        new JdeField("V1OKC", "V1OKC", JdeDataType.String, 10),
        new JdeField("V1ODOC", "V1ODOC", JdeDataType.Numeric),
        new JdeField("V1ODCT", "V1ODCT", JdeDataType.String, 4),
        new JdeField("V1AN8R", "V1AN8R", JdeDataType.Numeric),
        new JdeField("V1IVD", "V1IVD", JdeDataType.Numeric),
        new JdeField("V1P74TLDJ", "V1P74TLDJ", JdeDataType.Numeric),
        new JdeField("V1URCD", "V1URCD", JdeDataType.String, 4),
        new JdeField("V1URDT", "V1URDT", JdeDataType.Numeric),
        new JdeField("V1URAT", "V1URAT", JdeDataType.Numeric),
        new JdeField("V1URAB", "V1URAB", JdeDataType.Numeric),
        new JdeField("V1URRF", "V1URRF", JdeDataType.String, 30),
        new JdeField("V1FUTMN1", "V1FUTMN1", JdeDataType.Numeric),
        new JdeField("V1FUTMN2", "V1FUTMN2", JdeDataType.Numeric),
        new JdeField("V1FUTMN3", "V1FUTMN3", JdeDataType.Numeric),
        new JdeField("V1FUTSTG1", "V1FUTSTG1", JdeDataType.String, 100),
        new JdeField("V1FUTSTG2", "V1FUTSTG2", JdeDataType.String, 100),
        new JdeField("V1FUTSTG3", "V1FUTSTG3", JdeDataType.String, 100),
        new JdeField("V1FUTDJ1", "V1FUTDJ1", JdeDataType.Numeric),
        new JdeField("V1FUTDJ2", "V1FUTDJ2", JdeDataType.Numeric),
        new JdeField("V1FUTDJ3", "V1FUTDJ3", JdeDataType.Numeric),
        new JdeField("V1FUTCHR1", "V1FUTCHR1", JdeDataType.String, 2),
        new JdeField("V1FUTCHR2", "V1FUTCHR2", JdeDataType.String, 2),
        new JdeField("V1FUTCHR3", "V1FUTCHR3", JdeDataType.String, 2),
        new JdeField("V1USER", "V1USER", JdeDataType.String, 20),
        new JdeField("V1PID", "V1PID", JdeDataType.String, 20),
        new JdeField("V1JOBN", "V1JOBN", JdeDataType.String, 20),
        new JdeField("V1UPMJ", "V1UPMJ", JdeDataType.Numeric),
        new JdeField("V1UPMT", "V1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P411Z_0", "Primary Key on V1EDUS, V1EDBT, V1EDTN", new[] { "V1EDUS", "V1EDBT", "V1EDTN" }, isUnique: true, isPrimaryKey: true)
    };
}
