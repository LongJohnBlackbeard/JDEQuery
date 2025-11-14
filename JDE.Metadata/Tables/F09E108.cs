using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09E108 - .
/// </summary>
public class F09E108 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRPOLICY.
        /// </summary>
        public const string PRPOLICY = "PRPOLICY";

        /// <summary>
        /// PRDL01.
        /// </summary>
        public const string PRDL01 = "PRDL01";

        /// <summary>
        /// PRNONBILL.
        /// </summary>
        public const string PRNONBILL = "PRNONBILL";

        /// <summary>
        /// PREXPTYPE.
        /// </summary>
        public const string PREXPTYPE = "PREXPTYPE";

        /// <summary>
        /// PREFTJ.
        /// </summary>
        public const string PREFTJ = "PREFTJ";

        /// <summary>
        /// PREXRPTTYP.
        /// </summary>
        public const string PREXRPTTYP = "PREXRPTTYP";

        /// <summary>
        /// PRLOCATN.
        /// </summary>
        public const string PRLOCATN = "PRLOCATN";

        /// <summary>
        /// PREXDJ.
        /// </summary>
        public const string PREXDJ = "PREXDJ";

        /// <summary>
        /// PRDEFTRATE.
        /// </summary>
        public const string PRDEFTRATE = "PRDEFTRATE";

        /// <summary>
        /// PRRATE1.
        /// </summary>
        public const string PRRATE1 = "PRRATE1";

        /// <summary>
        /// PRRATEOVRD.
        /// </summary>
        public const string PRRATEOVRD = "PRRATEOVRD";

        /// <summary>
        /// PRDLYALLOW.
        /// </summary>
        public const string PRDLYALLOW = "PRDLYALLOW";

        /// <summary>
        /// PRTOLER.
        /// </summary>
        public const string PRTOLER = "PRTOLER";

        /// <summary>
        /// PRAUDITAMT.
        /// </summary>
        public const string PRAUDITAMT = "PRAUDITAMT";

        /// <summary>
        /// PRRCTRQD.
        /// </summary>
        public const string PRRCTRQD = "PRRCTRQD";

        /// <summary>
        /// PRDOMRCTAM.
        /// </summary>
        public const string PRDOMRCTAM = "PRDOMRCTAM";

        /// <summary>
        /// PRPREFSUP.
        /// </summary>
        public const string PRPREFSUP = "PRPREFSUP";

        /// <summary>
        /// PRHEDIT.
        /// </summary>
        public const string PRHEDIT = "PRHEDIT";

        /// <summary>
        /// PRPOLCRCY.
        /// </summary>
        public const string PRPOLCRCY = "PRPOLCRCY";

        /// <summary>
        /// PRUM.
        /// </summary>
        public const string PRUM = "PRUM";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";

        /// <summary>
        /// PRJOBN.
        /// </summary>
        public const string PRJOBN = "PRJOBN";

        /// <summary>
        /// PRUPMJ.
        /// </summary>
        public const string PRUPMJ = "PRUPMJ";

        /// <summary>
        /// PRUPMT.
        /// </summary>
        public const string PRUPMT = "PRUPMT";

        /// <summary>
        /// PRPDIEMCAT.
        /// </summary>
        public const string PRPDIEMCAT = "PRPDIEMCAT";

        /// <summary>
        /// PRGOVTFLAG.
        /// </summary>
        public const string PRGOVTFLAG = "PRGOVTFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F09E108";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRPOLICY", "PRPOLICY", JdeDataType.String, 10, true, true),
        new JdeField("PRDL01", "PRDL01", JdeDataType.String, 60),
        new JdeField("PRNONBILL", "PRNONBILL", JdeDataType.String, 2),
        new JdeField("PREXPTYPE", "PREXPTYPE", JdeDataType.String, 8, true, true),
        new JdeField("PREFTJ", "PREFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PREXRPTTYP", "PREXRPTTYP", JdeDataType.String, 2, true, true),
        new JdeField("PRLOCATN", "PRLOCATN", JdeDataType.String, 20, true, true),
        new JdeField("PREXDJ", "PREXDJ", JdeDataType.Numeric),
        new JdeField("PRDEFTRATE", "PRDEFTRATE", JdeDataType.String, 2),
        new JdeField("PRRATE1", "PRRATE1", JdeDataType.Numeric),
        new JdeField("PRRATEOVRD", "PRRATEOVRD", JdeDataType.String, 2),
        new JdeField("PRDLYALLOW", "PRDLYALLOW", JdeDataType.Numeric),
        new JdeField("PRTOLER", "PRTOLER", JdeDataType.Numeric),
        new JdeField("PRAUDITAMT", "PRAUDITAMT", JdeDataType.Numeric),
        new JdeField("PRRCTRQD", "PRRCTRQD", JdeDataType.String, 2),
        new JdeField("PRDOMRCTAM", "PRDOMRCTAM", JdeDataType.Numeric),
        new JdeField("PRPREFSUP", "PRPREFSUP", JdeDataType.String, 2),
        new JdeField("PRHEDIT", "PRHEDIT", JdeDataType.String, 2),
        new JdeField("PRPOLCRCY", "PRPOLCRCY", JdeDataType.String, 6),
        new JdeField("PRUM", "PRUM", JdeDataType.String, 4),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20),
        new JdeField("PRJOBN", "PRJOBN", JdeDataType.String, 20),
        new JdeField("PRUPMJ", "PRUPMJ", JdeDataType.Numeric),
        new JdeField("PRUPMT", "PRUPMT", JdeDataType.Numeric),
        new JdeField("PRPDIEMCAT", "PRPDIEMCAT", JdeDataType.String, 8),
        new JdeField("PRGOVTFLAG", "PRGOVTFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09E108_0", "Primary Key on PRPOLICY, PREXPTYPE, PREFTJ, PREXRPTTYP, PRLOCATN", new[] { "PRPOLICY", "PREXPTYPE", "PREFTJ", "PREXRPTTYP", "PRLOCATN" }, isUnique: true, isPrimaryKey: true)
    };
}
