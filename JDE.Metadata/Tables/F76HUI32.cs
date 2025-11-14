using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76HUI32 - .
/// </summary>
public class F76HUI32 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFCTID.
        /// </summary>
        public const string WFCTID = "WFCTID";

        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFCSQ.
        /// </summary>
        public const string WFCSQ = "WFCSQ";

        /// <summary>
        /// WFKCO.
        /// </summary>
        public const string WFKCO = "WFKCO";

        /// <summary>
        /// WFDCT.
        /// </summary>
        public const string WFDCT = "WFDCT";

        /// <summary>
        /// WFDOC.
        /// </summary>
        public const string WFDOC = "WFDOC";

        /// <summary>
        /// WFH76LECO.
        /// </summary>
        public const string WFH76LECO = "WFH76LECO";

        /// <summary>
        /// WFH76LEDT.
        /// </summary>
        public const string WFH76LEDT = "WFH76LEDT";

        /// <summary>
        /// WFH76EMS.
        /// </summary>
        public const string WFH76EMS = "WFH76EMS";

        /// <summary>
        /// WFH76LENU.
        /// </summary>
        public const string WFH76LENU = "WFH76LENU";

        /// <summary>
        /// WFDGJ.
        /// </summary>
        public const string WFDGJ = "WFDGJ";

        /// <summary>
        /// WFDIVJ.
        /// </summary>
        public const string WFDIVJ = "WFDIVJ";

        /// <summary>
        /// WFICUT.
        /// </summary>
        public const string WFICUT = "WFICUT";

        /// <summary>
        /// WFICU.
        /// </summary>
        public const string WFICU = "WFICU";

        /// <summary>
        /// WFTAX.
        /// </summary>
        public const string WFTAX = "WFTAX";

        /// <summary>
        /// WFALPH.
        /// </summary>
        public const string WFALPH = "WFALPH";

        /// <summary>
        /// WFREF.
        /// </summary>
        public const string WFREF = "WFREF";

        /// <summary>
        /// WFAG.
        /// </summary>
        public const string WFAG = "WFAG";

        /// <summary>
        /// WFCRCD.
        /// </summary>
        public const string WFCRCD = "WFCRCD";

        /// <summary>
        /// WFATXA.
        /// </summary>
        public const string WFATXA = "WFATXA";

        /// <summary>
        /// WFATXN.
        /// </summary>
        public const string WFATXN = "WFATXN";

        /// <summary>
        /// WFSTA1.
        /// </summary>
        public const string WFSTA1 = "WFSTA1";

        /// <summary>
        /// WFSTA2.
        /// </summary>
        public const string WFSTA2 = "WFSTA2";

        /// <summary>
        /// WFTXA1.
        /// </summary>
        public const string WFTXA1 = "WFTXA1";

        /// <summary>
        /// WFEXR1.
        /// </summary>
        public const string WFEXR1 = "WFEXR1";

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
        /// WFVOID.
        /// </summary>
        public const string WFVOID = "WFVOID";
    }

    /// <inheritdoc />
    public override string TableName => "F76HUI32";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFCTID", "WFCTID", JdeDataType.String, 30, true, true),
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFCSQ", "WFCSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WFKCO", "WFKCO", JdeDataType.String, 10),
        new JdeField("WFDCT", "WFDCT", JdeDataType.String, 4),
        new JdeField("WFDOC", "WFDOC", JdeDataType.Numeric),
        new JdeField("WFH76LECO", "WFH76LECO", JdeDataType.String, 10),
        new JdeField("WFH76LEDT", "WFH76LEDT", JdeDataType.String, 6),
        new JdeField("WFH76EMS", "WFH76EMS", JdeDataType.String, 8),
        new JdeField("WFH76LENU", "WFH76LENU", JdeDataType.Numeric),
        new JdeField("WFDGJ", "WFDGJ", JdeDataType.Numeric),
        new JdeField("WFDIVJ", "WFDIVJ", JdeDataType.Numeric),
        new JdeField("WFICUT", "WFICUT", JdeDataType.String, 4),
        new JdeField("WFICU", "WFICU", JdeDataType.Numeric),
        new JdeField("WFTAX", "WFTAX", JdeDataType.String, 40),
        new JdeField("WFALPH", "WFALPH", JdeDataType.String, 80),
        new JdeField("WFREF", "WFREF", JdeDataType.String, 30),
        new JdeField("WFAG", "WFAG", JdeDataType.Numeric),
        new JdeField("WFCRCD", "WFCRCD", JdeDataType.String, 6),
        new JdeField("WFATXA", "WFATXA", JdeDataType.Numeric),
        new JdeField("WFATXN", "WFATXN", JdeDataType.Numeric),
        new JdeField("WFSTA1", "WFSTA1", JdeDataType.Numeric),
        new JdeField("WFSTA2", "WFSTA2", JdeDataType.Numeric),
        new JdeField("WFTXA1", "WFTXA1", JdeDataType.String, 20),
        new JdeField("WFEXR1", "WFEXR1", JdeDataType.String, 4),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric),
        new JdeField("WFVOID", "WFVOID", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76HUI32_0", "Primary Key on WFCTID, WFJOBS, WFCSQ", new[] { "WFCTID", "WFJOBS", "WFCSQ" }, isUnique: true, isPrimaryKey: true)
    };
}
