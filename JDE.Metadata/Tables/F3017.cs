using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3017 - .
/// </summary>
public class F3017 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KSCALCID.
        /// </summary>
        public const string KSCALCID = "KSCALCID";

        /// <summary>
        /// KSDL01.
        /// </summary>
        public const string KSDL01 = "KSDL01";

        /// <summary>
        /// KSFCTNM.
        /// </summary>
        public const string KSFCTNM = "KSFCTNM";

        /// <summary>
        /// KSUNUMP.
        /// </summary>
        public const string KSUNUMP = "KSUNUMP";

        /// <summary>
        /// KSUNDAY.
        /// </summary>
        public const string KSUNDAY = "KSUNDAY";

        /// <summary>
        /// KSULTFL.
        /// </summary>
        public const string KSULTFL = "KSULTFL";

        /// <summary>
        /// KSULDAY.
        /// </summary>
        public const string KSULDAY = "KSULDAY";

        /// <summary>
        /// KSUVSPC.
        /// </summary>
        public const string KSUVSPC = "KSUVSPC";

        /// <summary>
        /// KSUSAFE.
        /// </summary>
        public const string KSUSAFE = "KSUSAFE";

        /// <summary>
        /// KSUPCDS.
        /// </summary>
        public const string KSUPCDS = "KSUPCDS";

        /// <summary>
        /// KSUUPC.
        /// </summary>
        public const string KSUUPC = "KSUUPC";

        /// <summary>
        /// KSUCNTS.
        /// </summary>
        public const string KSUCNTS = "KSUCNTS";

        /// <summary>
        /// KSUMCRD.
        /// </summary>
        public const string KSUMCRD = "KSUMCRD";

        /// <summary>
        /// KSUMXCRD.
        /// </summary>
        public const string KSUMXCRD = "KSUMXCRD";

        /// <summary>
        /// KSUMQTY.
        /// </summary>
        public const string KSUMQTY = "KSUMQTY";

        /// <summary>
        /// KSUMXQTY.
        /// </summary>
        public const string KSUMXQTY = "KSUMXQTY";

        /// <summary>
        /// KSUCP1.
        /// </summary>
        public const string KSUCP1 = "KSUCP1";

        /// <summary>
        /// KSUCP2.
        /// </summary>
        public const string KSUCP2 = "KSUCP2";

        /// <summary>
        /// KSUCP3.
        /// </summary>
        public const string KSUCP3 = "KSUCP3";

        /// <summary>
        /// KSUSER.
        /// </summary>
        public const string KSUSER = "KSUSER";

        /// <summary>
        /// KSPID.
        /// </summary>
        public const string KSPID = "KSPID";

        /// <summary>
        /// KSMKEY.
        /// </summary>
        public const string KSMKEY = "KSMKEY";

        /// <summary>
        /// KSUPMJ.
        /// </summary>
        public const string KSUPMJ = "KSUPMJ";

        /// <summary>
        /// KSUPMT.
        /// </summary>
        public const string KSUPMT = "KSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F3017";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KSCALCID", "KSCALCID", JdeDataType.String, 20, true, true),
        new JdeField("KSDL01", "KSDL01", JdeDataType.String, 60),
        new JdeField("KSFCTNM", "KSFCTNM", JdeDataType.String, 64),
        new JdeField("KSUNUMP", "KSUNUMP", JdeDataType.String, 2),
        new JdeField("KSUNDAY", "KSUNDAY", JdeDataType.String, 2),
        new JdeField("KSULTFL", "KSULTFL", JdeDataType.String, 2),
        new JdeField("KSULDAY", "KSULDAY", JdeDataType.String, 2),
        new JdeField("KSUVSPC", "KSUVSPC", JdeDataType.String, 2),
        new JdeField("KSUSAFE", "KSUSAFE", JdeDataType.String, 2),
        new JdeField("KSUPCDS", "KSUPCDS", JdeDataType.String, 2),
        new JdeField("KSUUPC", "KSUUPC", JdeDataType.String, 2),
        new JdeField("KSUCNTS", "KSUCNTS", JdeDataType.String, 2),
        new JdeField("KSUMCRD", "KSUMCRD", JdeDataType.String, 2),
        new JdeField("KSUMXCRD", "KSUMXCRD", JdeDataType.String, 2),
        new JdeField("KSUMQTY", "KSUMQTY", JdeDataType.String, 2),
        new JdeField("KSUMXQTY", "KSUMXQTY", JdeDataType.String, 2),
        new JdeField("KSUCP1", "KSUCP1", JdeDataType.String, 2),
        new JdeField("KSUCP2", "KSUCP2", JdeDataType.String, 2),
        new JdeField("KSUCP3", "KSUCP3", JdeDataType.String, 2),
        new JdeField("KSUSER", "KSUSER", JdeDataType.String, 20),
        new JdeField("KSPID", "KSPID", JdeDataType.String, 20),
        new JdeField("KSMKEY", "KSMKEY", JdeDataType.String, 30),
        new JdeField("KSUPMJ", "KSUPMJ", JdeDataType.Numeric),
        new JdeField("KSUPMT", "KSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3017_0", "Primary Key on KSCALCID", new[] { "KSCALCID" }, isUnique: true, isPrimaryKey: true)
    };
}
