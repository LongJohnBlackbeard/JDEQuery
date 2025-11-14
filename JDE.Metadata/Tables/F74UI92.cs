using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74UI92 - .
/// </summary>
public class F74UI92 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CVJOBS.
        /// </summary>
        public const string CVJOBS = "CVJOBS";

        /// <summary>
        /// CVE74RENA.
        /// </summary>
        public const string CVE74RENA = "CVE74RENA";

        /// <summary>
        /// CVE74RSN.
        /// </summary>
        public const string CVE74RSN = "CVE74RSN";

        /// <summary>
        /// CVE74RRN.
        /// </summary>
        public const string CVE74RRN = "CVE74RRN";

        /// <summary>
        /// CVE74ASEQ.
        /// </summary>
        public const string CVE74ASEQ = "CVE74ASEQ";

        /// <summary>
        /// CVE74CNO.
        /// </summary>
        public const string CVE74CNO = "CVE74CNO";

        /// <summary>
        /// CVE74VIS.
        /// </summary>
        public const string CVE74VIS = "CVE74VIS";

        /// <summary>
        /// CVE74RA.
        /// </summary>
        public const string CVE74RA = "CVE74RA";

        /// <summary>
        /// CVE74FUNC.
        /// </summary>
        public const string CVE74FUNC = "CVE74FUNC";

        /// <summary>
        /// CVFYOF.
        /// </summary>
        public const string CVFYOF = "CVFYOF";

        /// <summary>
        /// CVPNOF.
        /// </summary>
        public const string CVPNOF = "CVPNOF";

        /// <summary>
        /// CVE74LT.
        /// </summary>
        public const string CVE74LT = "CVE74LT";

        /// <summary>
        /// CVCRCD.
        /// </summary>
        public const string CVCRCD = "CVCRCD";

        /// <summary>
        /// CVE74LT01.
        /// </summary>
        public const string CVE74LT01 = "CVE74LT01";

        /// <summary>
        /// CVE74RA01.
        /// </summary>
        public const string CVE74RA01 = "CVE74RA01";

        /// <summary>
        /// CVE74LT02.
        /// </summary>
        public const string CVE74LT02 = "CVE74LT02";

        /// <summary>
        /// CVE74RA02.
        /// </summary>
        public const string CVE74RA02 = "CVE74RA02";

        /// <summary>
        /// CVE74LT03.
        /// </summary>
        public const string CVE74LT03 = "CVE74LT03";

        /// <summary>
        /// CVE74RA03.
        /// </summary>
        public const string CVE74RA03 = "CVE74RA03";

        /// <summary>
        /// CVE74LT04.
        /// </summary>
        public const string CVE74LT04 = "CVE74LT04";

        /// <summary>
        /// CVE74RA04.
        /// </summary>
        public const string CVE74RA04 = "CVE74RA04";

        /// <summary>
        /// CVE74CALC.
        /// </summary>
        public const string CVE74CALC = "CVE74CALC";

        /// <summary>
        /// CVCTRY.
        /// </summary>
        public const string CVCTRY = "CVCTRY";

        /// <summary>
        /// CVFY.
        /// </summary>
        public const string CVFY = "CVFY";

        /// <summary>
        /// CVPN.
        /// </summary>
        public const string CVPN = "CVPN";

        /// <summary>
        /// CVE74FORM.
        /// </summary>
        public const string CVE74FORM = "CVE74FORM";

        /// <summary>
        /// CVE74FACT.
        /// </summary>
        public const string CVE74FACT = "CVE74FACT";

        /// <summary>
        /// CVE74FDLE.
        /// </summary>
        public const string CVE74FDLE = "CVE74FDLE";

        /// <summary>
        /// CVE74CSTO.
        /// </summary>
        public const string CVE74CSTO = "CVE74CSTO";
    }

    /// <inheritdoc />
    public override string TableName => "F74UI92";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CVJOBS", "CVJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CVE74RENA", "CVE74RENA", JdeDataType.String, 40, true, true),
        new JdeField("CVE74RSN", "CVE74RSN", JdeDataType.Numeric, null, true, true),
        new JdeField("CVE74RRN", "CVE74RRN", JdeDataType.Numeric, null, true, true),
        new JdeField("CVE74ASEQ", "CVE74ASEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CVE74CNO", "CVE74CNO", JdeDataType.String, 4, true, true),
        new JdeField("CVE74VIS", "CVE74VIS", JdeDataType.String, 2),
        new JdeField("CVE74RA", "CVE74RA", JdeDataType.Numeric),
        new JdeField("CVE74FUNC", "CVE74FUNC", JdeDataType.String, 20),
        new JdeField("CVFYOF", "CVFYOF", JdeDataType.String, 6),
        new JdeField("CVPNOF", "CVPNOF", JdeDataType.String, 6),
        new JdeField("CVE74LT", "CVE74LT", JdeDataType.String, 4),
        new JdeField("CVCRCD", "CVCRCD", JdeDataType.String, 6),
        new JdeField("CVE74LT01", "CVE74LT01", JdeDataType.String, 4),
        new JdeField("CVE74RA01", "CVE74RA01", JdeDataType.Numeric),
        new JdeField("CVE74LT02", "CVE74LT02", JdeDataType.String, 4),
        new JdeField("CVE74RA02", "CVE74RA02", JdeDataType.Numeric),
        new JdeField("CVE74LT03", "CVE74LT03", JdeDataType.String, 4),
        new JdeField("CVE74RA03", "CVE74RA03", JdeDataType.Numeric),
        new JdeField("CVE74LT04", "CVE74LT04", JdeDataType.String, 4),
        new JdeField("CVE74RA04", "CVE74RA04", JdeDataType.Numeric),
        new JdeField("CVE74CALC", "CVE74CALC", JdeDataType.String, 2),
        new JdeField("CVCTRY", "CVCTRY", JdeDataType.Numeric),
        new JdeField("CVFY", "CVFY", JdeDataType.Numeric),
        new JdeField("CVPN", "CVPN", JdeDataType.Numeric),
        new JdeField("CVE74FORM", "CVE74FORM", JdeDataType.String, 480),
        new JdeField("CVE74FACT", "CVE74FACT", JdeDataType.String, 2),
        new JdeField("CVE74FDLE", "CVE74FDLE", JdeDataType.String, 2),
        new JdeField("CVE74CSTO", "CVE74CSTO", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74UI92_0", "Primary Key on CVJOBS, CVE74RENA, CVE74RSN, CVE74RRN, CVE74ASEQ, CVE74CNO", new[] { "CVJOBS", "CVE74RENA", "CVE74RSN", "CVE74RRN", "CVE74ASEQ", "CVE74CNO" }, isUnique: true, isPrimaryKey: true)
    };
}
