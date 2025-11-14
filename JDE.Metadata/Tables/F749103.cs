using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F749103 - .
/// </summary>
public class F749103 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDE74RENA.
        /// </summary>
        public const string CDE74RENA = "CDE74RENA";

        /// <summary>
        /// CDE74RSN.
        /// </summary>
        public const string CDE74RSN = "CDE74RSN";

        /// <summary>
        /// CDE74CNO.
        /// </summary>
        public const string CDE74CNO = "CDE74CNO";

        /// <summary>
        /// CDE74CT01.
        /// </summary>
        public const string CDE74CT01 = "CDE74CT01";

        /// <summary>
        /// CDE74CT02.
        /// </summary>
        public const string CDE74CT02 = "CDE74CT02";

        /// <summary>
        /// CDE74CTL1.
        /// </summary>
        public const string CDE74CTL1 = "CDE74CTL1";

        /// <summary>
        /// CDE74CTL2.
        /// </summary>
        public const string CDE74CTL2 = "CDE74CTL2";

        /// <summary>
        /// CDE74FUNC.
        /// </summary>
        public const string CDE74FUNC = "CDE74FUNC";

        /// <summary>
        /// CDE74FORM.
        /// </summary>
        public const string CDE74FORM = "CDE74FORM";

        /// <summary>
        /// CDE74FACT.
        /// </summary>
        public const string CDE74FACT = "CDE74FACT";

        /// <summary>
        /// CDFYOF.
        /// </summary>
        public const string CDFYOF = "CDFYOF";

        /// <summary>
        /// CDPNOF.
        /// </summary>
        public const string CDPNOF = "CDPNOF";

        /// <summary>
        /// CDLT.
        /// </summary>
        public const string CDLT = "CDLT";

        /// <summary>
        /// CDCRCD.
        /// </summary>
        public const string CDCRCD = "CDCRCD";

        /// <summary>
        /// CDE74CSTO.
        /// </summary>
        public const string CDE74CSTO = "CDE74CSTO";

        /// <summary>
        /// CDE74VIS.
        /// </summary>
        public const string CDE74VIS = "CDE74VIS";

        /// <summary>
        /// CDE74COTY.
        /// </summary>
        public const string CDE74COTY = "CDE74COTY";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDJOBN.
        /// </summary>
        public const string CDJOBN = "CDJOBN";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

        /// <summary>
        /// CDUPMJ.
        /// </summary>
        public const string CDUPMJ = "CDUPMJ";

        /// <summary>
        /// CDUPMT.
        /// </summary>
        public const string CDUPMT = "CDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F749103";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDE74RENA", "CDE74RENA", JdeDataType.String, 40, true, true),
        new JdeField("CDE74RSN", "CDE74RSN", JdeDataType.Numeric, null, true, true),
        new JdeField("CDE74CNO", "CDE74CNO", JdeDataType.String, 4, true, true),
        new JdeField("CDE74CT01", "CDE74CT01", JdeDataType.String, 30),
        new JdeField("CDE74CT02", "CDE74CT02", JdeDataType.String, 30),
        new JdeField("CDE74CTL1", "CDE74CTL1", JdeDataType.String, 60),
        new JdeField("CDE74CTL2", "CDE74CTL2", JdeDataType.String, 60),
        new JdeField("CDE74FUNC", "CDE74FUNC", JdeDataType.String, 20),
        new JdeField("CDE74FORM", "CDE74FORM", JdeDataType.String, 480),
        new JdeField("CDE74FACT", "CDE74FACT", JdeDataType.String, 2),
        new JdeField("CDFYOF", "CDFYOF", JdeDataType.String, 6),
        new JdeField("CDPNOF", "CDPNOF", JdeDataType.String, 6),
        new JdeField("CDLT", "CDLT", JdeDataType.String, 4),
        new JdeField("CDCRCD", "CDCRCD", JdeDataType.String, 6),
        new JdeField("CDE74CSTO", "CDE74CSTO", JdeDataType.String, 2),
        new JdeField("CDE74VIS", "CDE74VIS", JdeDataType.String, 2),
        new JdeField("CDE74COTY", "CDE74COTY", JdeDataType.String, 2),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F749103_0", "Primary Key on CDE74RENA, CDE74RSN, CDE74CNO", new[] { "CDE74RENA", "CDE74RSN", "CDE74CNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F749103_2", "Index on CDE74RENA, CDE74RSN, SYS_NC00023$", new[] { "CDE74RENA", "CDE74RSN", "SYS_NC00023$" })
    };
}
