using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F741202 - .
/// </summary>
public class F741202 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFAID.
        /// </summary>
        public const string WFAID = "WFAID";

        /// <summary>
        /// WFCTRY.
        /// </summary>
        public const string WFCTRY = "WFCTRY";

        /// <summary>
        /// WFFY.
        /// </summary>
        public const string WFFY = "WFFY";

        /// <summary>
        /// WFFQ.
        /// </summary>
        public const string WFFQ = "WFFQ";

        /// <summary>
        /// WFLT.
        /// </summary>
        public const string WFLT = "WFLT";

        /// <summary>
        /// WFSBL.
        /// </summary>
        public const string WFSBL = "WFSBL";

        /// <summary>
        /// WFSBLT.
        /// </summary>
        public const string WFSBLT = "WFSBLT";

        /// <summary>
        /// WFNUMB.
        /// </summary>
        public const string WFNUMB = "WFNUMB";

        /// <summary>
        /// WFCO.
        /// </summary>
        public const string WFCO = "WFCO";

        /// <summary>
        /// WFMCU.
        /// </summary>
        public const string WFMCU = "WFMCU";

        /// <summary>
        /// WFOBJ.
        /// </summary>
        public const string WFOBJ = "WFOBJ";

        /// <summary>
        /// WFSUB.
        /// </summary>
        public const string WFSUB = "WFSUB";

        /// <summary>
        /// WFACL1.
        /// </summary>
        public const string WFACL1 = "WFACL1";

        /// <summary>
        /// WFFA1.
        /// </summary>
        public const string WFFA1 = "WFFA1";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFPID.
        /// </summary>
        public const string WFPID = "WFPID";

        /// <summary>
        /// WFJOBN.
        /// </summary>
        public const string WFJOBN = "WFJOBN";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";

        /// <summary>
        /// WFUPMT.
        /// </summary>
        public const string WFUPMT = "WFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F741202";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFAID", "WFAID", JdeDataType.String, 16, true, true),
        new JdeField("WFCTRY", "WFCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("WFFY", "WFFY", JdeDataType.Numeric, null, true, true),
        new JdeField("WFFQ", "WFFQ", JdeDataType.String, 8, true, true),
        new JdeField("WFLT", "WFLT", JdeDataType.String, 4, true, true),
        new JdeField("WFSBL", "WFSBL", JdeDataType.String, 16, true, true),
        new JdeField("WFSBLT", "WFSBLT", JdeDataType.String, 2, true, true),
        new JdeField("WFNUMB", "WFNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("WFCO", "WFCO", JdeDataType.String, 10),
        new JdeField("WFMCU", "WFMCU", JdeDataType.String, 24),
        new JdeField("WFOBJ", "WFOBJ", JdeDataType.String, 12),
        new JdeField("WFSUB", "WFSUB", JdeDataType.String, 16),
        new JdeField("WFACL1", "WFACL1", JdeDataType.String, 6),
        new JdeField("WFFA1", "WFFA1", JdeDataType.String, 6),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFJOBN", "WFJOBN", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F741202_0", "Primary Key on WFAID, WFCTRY, WFFY, WFFQ, WFLT, WFSBL, WFSBLT, WFNUMB", new[] { "WFAID", "WFCTRY", "WFFY", "WFFQ", "WFLT", "WFSBL", "WFSBLT", "WFNUMB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F741202_2", "Index on WFCO, WFMCU, WFFA1, WFOBJ, WFNUMB", new[] { "WFCO", "WFMCU", "WFFA1", "WFOBJ", "WFNUMB" })
    };
}
