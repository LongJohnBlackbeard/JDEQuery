using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A396 - .
/// </summary>
public class F76A396 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSCRCD.
        /// </summary>
        public const string CSCRCD = "CSCRCD";

        /// <summary>
        /// CSCO.
        /// </summary>
        public const string CSCO = "CSCO";

        /// <summary>
        /// CSITPL.
        /// </summary>
        public const string CSITPL = "CSITPL";

        /// <summary>
        /// CSITM.
        /// </summary>
        public const string CSITM = "CSITM";

        /// <summary>
        /// CSEFTE.
        /// </summary>
        public const string CSEFTE = "CSEFTE";

        /// <summary>
        /// CSUNCS.
        /// </summary>
        public const string CSUNCS = "CSUNCS";

        /// <summary>
        /// CSSVDT.
        /// </summary>
        public const string CSSVDT = "CSSVDT";

        /// <summary>
        /// CSSVFU.
        /// </summary>
        public const string CSSVFU = "CSSVFU";

        /// <summary>
        /// CSSVF1.
        /// </summary>
        public const string CSSVF1 = "CSSVF1";

        /// <summary>
        /// CSSVF2.
        /// </summary>
        public const string CSSVF2 = "CSSVF2";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSTDAY.
        /// </summary>
        public const string CSTDAY = "CSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76A396";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSCRCD", "CSCRCD", JdeDataType.String, 6, true, true),
        new JdeField("CSCO", "CSCO", JdeDataType.String, 10, true, true),
        new JdeField("CSITPL", "CSITPL", JdeDataType.String, 20, true, true),
        new JdeField("CSITM", "CSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CSEFTE", "CSEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("CSUNCS", "CSUNCS", JdeDataType.Numeric),
        new JdeField("CSSVDT", "CSSVDT", JdeDataType.Numeric),
        new JdeField("CSSVFU", "CSSVFU", JdeDataType.String, 4),
        new JdeField("CSSVF1", "CSSVF1", JdeDataType.String, 2),
        new JdeField("CSSVF2", "CSSVF2", JdeDataType.String, 2),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSTDAY", "CSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A396_0", "Primary Key on CSCRCD, CSCO, CSITPL, CSITM, CSEFTE", new[] { "CSCRCD", "CSCO", "CSITPL", "CSITM", "CSEFTE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A396_2", "Index on CSCO, CSITM, SYS_NC00016$", new[] { "CSCO", "CSITM", "SYS_NC00016$" })
    };
}
