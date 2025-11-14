using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U424W - .
/// </summary>
public class F74U424W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFDOCO.
        /// </summary>
        public const string WFDOCO = "WFDOCO";

        /// <summary>
        /// WFDCTO.
        /// </summary>
        public const string WFDCTO = "WFDCTO";

        /// <summary>
        /// WFKCOO.
        /// </summary>
        public const string WFKCOO = "WFKCOO";

        /// <summary>
        /// WFSFXO.
        /// </summary>
        public const string WFSFXO = "WFSFXO";

        /// <summary>
        /// WFLNID.
        /// </summary>
        public const string WFLNID = "WFLNID";

        /// <summary>
        /// WFICU.
        /// </summary>
        public const string WFICU = "WFICU";

        /// <summary>
        /// WFDGJ.
        /// </summary>
        public const string WFDGJ = "WFDGJ";

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
        /// WFSBLT.
        /// </summary>
        public const string WFSBLT = "WFSBLT";

        /// <summary>
        /// WFLITM.
        /// </summary>
        public const string WFLITM = "WFLITM";

        /// <summary>
        /// WFABT1.
        /// </summary>
        public const string WFABT1 = "WFABT1";

        /// <summary>
        /// WFABR1.
        /// </summary>
        public const string WFABR1 = "WFABR1";

        /// <summary>
        /// WFABT2.
        /// </summary>
        public const string WFABT2 = "WFABT2";

        /// <summary>
        /// WFABR2.
        /// </summary>
        public const string WFABR2 = "WFABR2";

        /// <summary>
        /// WFABT3.
        /// </summary>
        public const string WFABT3 = "WFABT3";

        /// <summary>
        /// WFABR3.
        /// </summary>
        public const string WFABR3 = "WFABR3";

        /// <summary>
        /// WFABT4.
        /// </summary>
        public const string WFABT4 = "WFABT4";

        /// <summary>
        /// WFABR4.
        /// </summary>
        public const string WFABR4 = "WFABR4";

        /// <summary>
        /// WF74UAMT1.
        /// </summary>
        public const string WF74UAMT1 = "WF74UAMT1";

        /// <summary>
        /// WF74UGFL.
        /// </summary>
        public const string WF74UGFL = "WF74UGFL";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFEDSP.
        /// </summary>
        public const string WFEDSP = "WFEDSP";

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

        /// <summary>
        /// WFMKEY.
        /// </summary>
        public const string WFMKEY = "WFMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F74U424W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFDOCO", "WFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WFDCTO", "WFDCTO", JdeDataType.String, 4, true, true),
        new JdeField("WFKCOO", "WFKCOO", JdeDataType.String, 10, true, true),
        new JdeField("WFSFXO", "WFSFXO", JdeDataType.String, 6, true, true),
        new JdeField("WFLNID", "WFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFICU", "WFICU", JdeDataType.Numeric, null, true, true),
        new JdeField("WFDGJ", "WFDGJ", JdeDataType.Numeric),
        new JdeField("WFMCU", "WFMCU", JdeDataType.String, 24),
        new JdeField("WFOBJ", "WFOBJ", JdeDataType.String, 12),
        new JdeField("WFSUB", "WFSUB", JdeDataType.String, 16),
        new JdeField("WFSBL", "WFSBL", JdeDataType.String, 16),
        new JdeField("WFSBLT", "WFSBLT", JdeDataType.String, 2),
        new JdeField("WFLITM", "WFLITM", JdeDataType.String, 50),
        new JdeField("WFABT1", "WFABT1", JdeDataType.String, 2),
        new JdeField("WFABR1", "WFABR1", JdeDataType.String, 24),
        new JdeField("WFABT2", "WFABT2", JdeDataType.String, 2),
        new JdeField("WFABR2", "WFABR2", JdeDataType.String, 24),
        new JdeField("WFABT3", "WFABT3", JdeDataType.String, 2),
        new JdeField("WFABR3", "WFABR3", JdeDataType.String, 24),
        new JdeField("WFABT4", "WFABT4", JdeDataType.String, 2),
        new JdeField("WFABR4", "WFABR4", JdeDataType.String, 24),
        new JdeField("WF74UAMT1", "WF74UAMT1", JdeDataType.Numeric),
        new JdeField("WF74UGFL", "WF74UGFL", JdeDataType.String, 2),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFEDSP", "WFEDSP", JdeDataType.String, 2),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFJOBN", "WFJOBN", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric),
        new JdeField("WFMKEY", "WFMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U424W_0", "Primary Key on WFDOCO, WFDCTO, WFKCOO, WFSFXO, WFLNID, WFICU", new[] { "WFDOCO", "WFDCTO", "WFKCOO", "WFSFXO", "WFLNID", "WFICU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U424W_2", "Index on WFDOCO, WFDCTO, WFKCOO, WFSFXO, WFEDSP", new[] { "WFDOCO", "WFDCTO", "WFKCOO", "WFSFXO", "WFEDSP" }),
        new JdeIndex("F74U424W_3", "Index on WFDOCO, WFDCTO, WFKCOO, WFSFXO, WFMCU, WFOBJ, WFSUB, WFSBL, WFSBLT, WFLITM", new[] { "WFDOCO", "WFDCTO", "WFKCOO", "WFSFXO", "WFMCU", "WFOBJ", "WFSUB", "WFSBL", "WFSBLT", "WFLITM" }),
        new JdeIndex("F74U424W_4", "Index on WFDOCO, WFDCTO, WFKCOO, WFSFXO, WF74UGFL", new[] { "WFDOCO", "WFDCTO", "WFKCOO", "WFSFXO", "WF74UGFL" }),
        new JdeIndex("F74U424W_5", "Index on WFDOCO, WFDCTO, WFKCOO, WFSFXO, WFICU", new[] { "WFDOCO", "WFDCTO", "WFKCOO", "WFSFXO", "WFICU" })
    };
}
