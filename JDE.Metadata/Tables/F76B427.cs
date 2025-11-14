using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B427 - .
/// </summary>
public class F76B427 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SNBNNF.
        /// </summary>
        public const string SNBNNF = "SNBNNF";

        /// <summary>
        /// SNBSER.
        /// </summary>
        public const string SNBSER = "SNBSER";

        /// <summary>
        /// SNN001.
        /// </summary>
        public const string SNN001 = "SNN001";

        /// <summary>
        /// SNDCT.
        /// </summary>
        public const string SNDCT = "SNDCT";

        /// <summary>
        /// SNUKID.
        /// </summary>
        public const string SNUKID = "SNUKID";

        /// <summary>
        /// SNBRTX.
        /// </summary>
        public const string SNBRTX = "SNBRTX";

        /// <summary>
        /// SNBRTX2.
        /// </summary>
        public const string SNBRTX2 = "SNBRTX2";

        /// <summary>
        /// SNBRTXB.
        /// </summary>
        public const string SNBRTXB = "SNBRTXB";

        /// <summary>
        /// SNBRTXA.
        /// </summary>
        public const string SNBRTXA = "SNBRTXA";

        /// <summary>
        /// SNBRTXR.
        /// </summary>
        public const string SNBRTXR = "SNBRTXR";

        /// <summary>
        /// SNB76MAF.
        /// </summary>
        public const string SNB76MAF = "SNB76MAF";

        /// <summary>
        /// SNB76SSWF.
        /// </summary>
        public const string SNB76SSWF = "SNB76SSWF";

        /// <summary>
        /// SNCALCDJ.
        /// </summary>
        public const string SNCALCDJ = "SNCALCDJ";

        /// <summary>
        /// SNUSER.
        /// </summary>
        public const string SNUSER = "SNUSER";

        /// <summary>
        /// SNPID.
        /// </summary>
        public const string SNPID = "SNPID";

        /// <summary>
        /// SNTORG.
        /// </summary>
        public const string SNTORG = "SNTORG";

        /// <summary>
        /// SNUPMT.
        /// </summary>
        public const string SNUPMT = "SNUPMT";

        /// <summary>
        /// SNUPMJ.
        /// </summary>
        public const string SNUPMJ = "SNUPMJ";

        /// <summary>
        /// SNJOBN.
        /// </summary>
        public const string SNJOBN = "SNJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76B427";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SNBNNF", "SNBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("SNBSER", "SNBSER", JdeDataType.String, 4, true, true),
        new JdeField("SNN001", "SNN001", JdeDataType.Numeric, null, true, true),
        new JdeField("SNDCT", "SNDCT", JdeDataType.String, 4, true, true),
        new JdeField("SNUKID", "SNUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SNBRTX", "SNBRTX", JdeDataType.String, 4, true, true),
        new JdeField("SNBRTX2", "SNBRTX2", JdeDataType.String, 16),
        new JdeField("SNBRTXB", "SNBRTXB", JdeDataType.Numeric),
        new JdeField("SNBRTXA", "SNBRTXA", JdeDataType.Numeric),
        new JdeField("SNBRTXR", "SNBRTXR", JdeDataType.Numeric),
        new JdeField("SNB76MAF", "SNB76MAF", JdeDataType.String, 2),
        new JdeField("SNB76SSWF", "SNB76SSWF", JdeDataType.String, 2),
        new JdeField("SNCALCDJ", "SNCALCDJ", JdeDataType.Numeric),
        new JdeField("SNUSER", "SNUSER", JdeDataType.String, 20),
        new JdeField("SNPID", "SNPID", JdeDataType.String, 20),
        new JdeField("SNTORG", "SNTORG", JdeDataType.String, 20),
        new JdeField("SNUPMT", "SNUPMT", JdeDataType.Numeric),
        new JdeField("SNUPMJ", "SNUPMJ", JdeDataType.Numeric),
        new JdeField("SNJOBN", "SNJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B427_0", "Primary Key on SNBNNF, SNBSER, SNN001, SNDCT, SNUKID, SNBRTX", new[] { "SNBNNF", "SNBSER", "SNN001", "SNDCT", "SNUKID", "SNBRTX" }, isUnique: true, isPrimaryKey: true)
    };
}
