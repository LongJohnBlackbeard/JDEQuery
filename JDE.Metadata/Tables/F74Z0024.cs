using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Z0024 - .
/// </summary>
public class F74Z0024 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CZDCT.
        /// </summary>
        public const string CZDCT = "CZDCT";

        /// <summary>
        /// CZZ74CC.
        /// </summary>
        public const string CZZ74CC = "CZZ74CC";

        /// <summary>
        /// CZFLAG.
        /// </summary>
        public const string CZFLAG = "CZFLAG";

        /// <summary>
        /// CZDEPFUT2.
        /// </summary>
        public const string CZDEPFUT2 = "CZDEPFUT2";

        /// <summary>
        /// CZDEPFUT1.
        /// </summary>
        public const string CZDEPFUT1 = "CZDEPFUT1";

        /// <summary>
        /// CZUPMT.
        /// </summary>
        public const string CZUPMT = "CZUPMT";

        /// <summary>
        /// CZUPMJ.
        /// </summary>
        public const string CZUPMJ = "CZUPMJ";

        /// <summary>
        /// CZPID.
        /// </summary>
        public const string CZPID = "CZPID";

        /// <summary>
        /// CZJOBN.
        /// </summary>
        public const string CZJOBN = "CZJOBN";

        /// <summary>
        /// CZUSER.
        /// </summary>
        public const string CZUSER = "CZUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F74Z0024";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CZDCT", "CZDCT", JdeDataType.String, 4, true, true),
        new JdeField("CZZ74CC", "CZZ74CC", JdeDataType.String, 6),
        new JdeField("CZFLAG", "CZFLAG", JdeDataType.String, 2),
        new JdeField("CZDEPFUT2", "CZDEPFUT2", JdeDataType.String, 60),
        new JdeField("CZDEPFUT1", "CZDEPFUT1", JdeDataType.String, 2),
        new JdeField("CZUPMT", "CZUPMT", JdeDataType.Numeric),
        new JdeField("CZUPMJ", "CZUPMJ", JdeDataType.Numeric),
        new JdeField("CZPID", "CZPID", JdeDataType.String, 20),
        new JdeField("CZJOBN", "CZJOBN", JdeDataType.String, 20),
        new JdeField("CZUSER", "CZUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Z0024_0", "Primary Key on CZDCT", new[] { "CZDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
