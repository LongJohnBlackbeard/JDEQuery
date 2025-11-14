using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B600 - .
/// </summary>
public class F76B600 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCBNNF.
        /// </summary>
        public const string CCBNNF = "CCBNNF";

        /// <summary>
        /// CCBSER.
        /// </summary>
        public const string CCBSER = "CCBSER";

        /// <summary>
        /// CCN001.
        /// </summary>
        public const string CCN001 = "CCN001";

        /// <summary>
        /// CCDCT.
        /// </summary>
        public const string CCDCT = "CCDCT";

        /// <summary>
        /// CCSEQ.
        /// </summary>
        public const string CCSEQ = "CCSEQ";

        /// <summary>
        /// CCB76AKEY.
        /// </summary>
        public const string CCB76AKEY = "CCB76AKEY";

        /// <summary>
        /// CCB76CCST.
        /// </summary>
        public const string CCB76CCST = "CCB76CCST";

        /// <summary>
        /// CCB76CTEXT.
        /// </summary>
        public const string CCB76CTEXT = "CCB76CTEXT";

        /// <summary>
        /// CCB76ECDT.
        /// </summary>
        public const string CCB76ECDT = "CCB76ECDT";

        /// <summary>
        /// CCB76ECT.
        /// </summary>
        public const string CCB76ECT = "CCB76ECT";

        /// <summary>
        /// CCB76PROC.
        /// </summary>
        public const string CCB76PROC = "CCB76PROC";

        /// <summary>
        /// CCB76CEAD.
        /// </summary>
        public const string CCB76CEAD = "CCB76CEAD";

        /// <summary>
        /// CCB76CEAT.
        /// </summary>
        public const string CCB76CEAT = "CCB76CEAT";

        /// <summary>
        /// CCFCHAR1.
        /// </summary>
        public const string CCFCHAR1 = "CCFCHAR1";

        /// <summary>
        /// CCFCHAR2.
        /// </summary>
        public const string CCFCHAR2 = "CCFCHAR2";

        /// <summary>
        /// CCFCHAR3.
        /// </summary>
        public const string CCFCHAR3 = "CCFCHAR3";

        /// <summary>
        /// CCFUDTE1.
        /// </summary>
        public const string CCFUDTE1 = "CCFUDTE1";

        /// <summary>
        /// CCFUDTE2.
        /// </summary>
        public const string CCFUDTE2 = "CCFUDTE2";

        /// <summary>
        /// CCFUDTE3.
        /// </summary>
        public const string CCFUDTE3 = "CCFUDTE3";

        /// <summary>
        /// CCFSTRN1.
        /// </summary>
        public const string CCFSTRN1 = "CCFSTRN1";

        /// <summary>
        /// CCFSTRN2.
        /// </summary>
        public const string CCFSTRN2 = "CCFSTRN2";

        /// <summary>
        /// CCFSTRN3.
        /// </summary>
        public const string CCFSTRN3 = "CCFSTRN3";

        /// <summary>
        /// CCFNUMB1.
        /// </summary>
        public const string CCFNUMB1 = "CCFNUMB1";

        /// <summary>
        /// CCFNUMB2.
        /// </summary>
        public const string CCFNUMB2 = "CCFNUMB2";

        /// <summary>
        /// CCFNUMB3.
        /// </summary>
        public const string CCFNUMB3 = "CCFNUMB3";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B600";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCBNNF", "CCBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("CCBSER", "CCBSER", JdeDataType.String, 4, true, true),
        new JdeField("CCN001", "CCN001", JdeDataType.Numeric, null, true, true),
        new JdeField("CCDCT", "CCDCT", JdeDataType.String, 4, true, true),
        new JdeField("CCSEQ", "CCSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CCB76AKEY", "CCB76AKEY", JdeDataType.String, 88),
        new JdeField("CCB76CCST", "CCB76CCST", JdeDataType.String, 2),
        new JdeField("CCB76CTEXT", "CCB76CTEXT", JdeDataType.String, 2000),
        new JdeField("CCB76ECDT", "CCB76ECDT", JdeDataType.Numeric),
        new JdeField("CCB76ECT", "CCB76ECT", JdeDataType.Numeric),
        new JdeField("CCB76PROC", "CCB76PROC", JdeDataType.Numeric),
        new JdeField("CCB76CEAD", "CCB76CEAD", JdeDataType.Numeric),
        new JdeField("CCB76CEAT", "CCB76CEAT", JdeDataType.Numeric),
        new JdeField("CCFCHAR1", "CCFCHAR1", JdeDataType.String, 2),
        new JdeField("CCFCHAR2", "CCFCHAR2", JdeDataType.String, 2),
        new JdeField("CCFCHAR3", "CCFCHAR3", JdeDataType.String, 2),
        new JdeField("CCFUDTE1", "CCFUDTE1", JdeDataType.Numeric),
        new JdeField("CCFUDTE2", "CCFUDTE2", JdeDataType.Numeric),
        new JdeField("CCFUDTE3", "CCFUDTE3", JdeDataType.Numeric),
        new JdeField("CCFSTRN1", "CCFSTRN1", JdeDataType.String, 100),
        new JdeField("CCFSTRN2", "CCFSTRN2", JdeDataType.String, 100),
        new JdeField("CCFSTRN3", "CCFSTRN3", JdeDataType.String, 100),
        new JdeField("CCFNUMB1", "CCFNUMB1", JdeDataType.Numeric),
        new JdeField("CCFNUMB2", "CCFNUMB2", JdeDataType.Numeric),
        new JdeField("CCFNUMB3", "CCFNUMB3", JdeDataType.Numeric),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B600_0", "Primary Key on CCBNNF, CCBSER, CCN001, CCDCT, CCSEQ", new[] { "CCBNNF", "CCBSER", "CCN001", "CCDCT", "CCSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B600_2", "Index on CCBNNF, CCBSER, CCDCT, CCN001, SYS_NC00031$", new[] { "CCBNNF", "CCBSER", "CCDCT", "CCN001", "SYS_NC00031$" })
    };
}
