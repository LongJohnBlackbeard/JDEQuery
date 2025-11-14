using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B314 - .
/// </summary>
public class F31B314 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LSMCU.
        /// </summary>
        public const string LSMCU = "LSMCU";

        /// <summary>
        /// LSWLOTN.
        /// </summary>
        public const string LSWLOTN = "LSWLOTN";

        /// <summary>
        /// LSSITEM.
        /// </summary>
        public const string LSSITEM = "LSSITEM";

        /// <summary>
        /// LSSVALUE.
        /// </summary>
        public const string LSSVALUE = "LSSVALUE";

        /// <summary>
        /// LSSTCFGFLG.
        /// </summary>
        public const string LSSTCFGFLG = "LSSTCFGFLG";

        /// <summary>
        /// LSSTTMROF.
        /// </summary>
        public const string LSSTTMROF = "LSSTTMROF";

        /// <summary>
        /// LSUSER.
        /// </summary>
        public const string LSUSER = "LSUSER";

        /// <summary>
        /// LSPID.
        /// </summary>
        public const string LSPID = "LSPID";

        /// <summary>
        /// LSJOBN.
        /// </summary>
        public const string LSJOBN = "LSJOBN";

        /// <summary>
        /// LSUPMJ.
        /// </summary>
        public const string LSUPMJ = "LSUPMJ";

        /// <summary>
        /// LSUPMT.
        /// </summary>
        public const string LSUPMT = "LSUPMT";

        /// <summary>
        /// LSSTYLEDT.
        /// </summary>
        public const string LSSTYLEDT = "LSSTYLEDT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B314";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LSMCU", "LSMCU", JdeDataType.String, 24, true, true),
        new JdeField("LSWLOTN", "LSWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("LSSITEM", "LSSITEM", JdeDataType.String, 24, true, true),
        new JdeField("LSSVALUE", "LSSVALUE", JdeDataType.Numeric),
        new JdeField("LSSTCFGFLG", "LSSTCFGFLG", JdeDataType.String, 2),
        new JdeField("LSSTTMROF", "LSSTTMROF", JdeDataType.String, 2),
        new JdeField("LSUSER", "LSUSER", JdeDataType.String, 20),
        new JdeField("LSPID", "LSPID", JdeDataType.String, 20),
        new JdeField("LSJOBN", "LSJOBN", JdeDataType.String, 20),
        new JdeField("LSUPMJ", "LSUPMJ", JdeDataType.Numeric),
        new JdeField("LSUPMT", "LSUPMT", JdeDataType.Numeric),
        new JdeField("LSSTYLEDT", "LSSTYLEDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B314_0", "Primary Key on LSMCU, LSWLOTN, LSSITEM", new[] { "LSMCU", "LSWLOTN", "LSSITEM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B314_2", "Index on LSMCU, LSWLOTN", new[] { "LSMCU", "LSWLOTN" })
    };
}
