using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09UI010 - .
/// </summary>
public class F09UI010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";

        /// <summary>
        /// WFUPMT.
        /// </summary>
        public const string WFUPMT = "WFUPMT";

        /// <summary>
        /// WFRSEQ.
        /// </summary>
        public const string WFRSEQ = "WFRSEQ";

        /// <summary>
        /// WFLT.
        /// </summary>
        public const string WFLT = "WFLT";

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
        /// WFSBL.
        /// </summary>
        public const string WFSBL = "WFSBL";

        /// <summary>
        /// WFAN01.
        /// </summary>
        public const string WFAN01 = "WFAN01";

        /// <summary>
        /// WFCO.
        /// </summary>
        public const string WFCO = "WFCO";

        /// <summary>
        /// WFFSBL.
        /// </summary>
        public const string WFFSBL = "WFFSBL";
    }

    /// <inheritdoc />
    public override string TableName => "F09UI010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20, true, true),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("WFRSEQ", "WFRSEQ", JdeDataType.String, 2, true, true),
        new JdeField("WFLT", "WFLT", JdeDataType.String, 4, true, true),
        new JdeField("WFMCU", "WFMCU", JdeDataType.String, 24, true, true),
        new JdeField("WFOBJ", "WFOBJ", JdeDataType.String, 12, true, true),
        new JdeField("WFSUB", "WFSUB", JdeDataType.String, 16, true, true),
        new JdeField("WFSBL", "WFSBL", JdeDataType.String, 16, true, true),
        new JdeField("WFAN01", "WFAN01", JdeDataType.Numeric),
        new JdeField("WFCO", "WFCO", JdeDataType.String, 10),
        new JdeField("WFFSBL", "WFFSBL", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09UI010_0", "Primary Key on WFUSER, WFUPMJ, WFUPMT, WFRSEQ, WFLT, WFMCU, WFOBJ, WFSUB, WFSBL", new[] { "WFUSER", "WFUPMJ", "WFUPMT", "WFRSEQ", "WFLT", "WFMCU", "WFOBJ", "WFSUB", "WFSBL" }, isPrimaryKey: true),
        new JdeIndex("F09UI010_3", "Index on WFUSER, WFUPMJ, WFUPMT, WFRSEQ", new[] { "WFUSER", "WFUPMJ", "WFUPMT", "WFRSEQ" }),
        new JdeIndex("F09UI010_4", "Index on WFUSER, WFUPMJ, WFUPMT, WFLT, WFSBL, WFFSBL", new[] { "WFUSER", "WFUPMJ", "WFUPMT", "WFLT", "WFSBL", "WFFSBL" }),
        new JdeIndex("F09UI010_5", "Index on WFUSER, WFUPMJ, WFUPMT, WFLT, WFCO, WFSUB", new[] { "WFUSER", "WFUPMJ", "WFUPMT", "WFLT", "WFCO", "WFSUB" })
    };
}
