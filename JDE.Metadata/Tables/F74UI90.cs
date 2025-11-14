using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74UI90 - .
/// </summary>
public class F74UI90 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDJOBS.
        /// </summary>
        public const string RDJOBS = "RDJOBS";

        /// <summary>
        /// RDE74RENA.
        /// </summary>
        public const string RDE74RENA = "RDE74RENA";

        /// <summary>
        /// RDE74RSN.
        /// </summary>
        public const string RDE74RSN = "RDE74RSN";

        /// <summary>
        /// RDE74RRN.
        /// </summary>
        public const string RDE74RRN = "RDE74RRN";

        /// <summary>
        /// RDE74LSEQ.
        /// </summary>
        public const string RDE74LSEQ = "RDE74LSEQ";

        /// <summary>
        /// RDE74RDES.
        /// </summary>
        public const string RDE74RDES = "RDE74RDES";

        /// <summary>
        /// RDANI.
        /// </summary>
        public const string RDANI = "RDANI";

        /// <summary>
        /// RDPEC.
        /// </summary>
        public const string RDPEC = "RDPEC";

        /// <summary>
        /// RDLDA.
        /// </summary>
        public const string RDLDA = "RDLDA";

        /// <summary>
        /// RDE74GR1.
        /// </summary>
        public const string RDE74GR1 = "RDE74GR1";

        /// <summary>
        /// RDE74GR2.
        /// </summary>
        public const string RDE74GR2 = "RDE74GR2";

        /// <summary>
        /// RDE74GR3.
        /// </summary>
        public const string RDE74GR3 = "RDE74GR3";

        /// <summary>
        /// RDE74RA01.
        /// </summary>
        public const string RDE74RA01 = "RDE74RA01";

        /// <summary>
        /// RDE74RA02.
        /// </summary>
        public const string RDE74RA02 = "RDE74RA02";

        /// <summary>
        /// RDE74RA03.
        /// </summary>
        public const string RDE74RA03 = "RDE74RA03";

        /// <summary>
        /// RDE74RA04.
        /// </summary>
        public const string RDE74RA04 = "RDE74RA04";

        /// <summary>
        /// RDE74RA05.
        /// </summary>
        public const string RDE74RA05 = "RDE74RA05";

        /// <summary>
        /// RDE74RA06.
        /// </summary>
        public const string RDE74RA06 = "RDE74RA06";

        /// <summary>
        /// RDE74RA07.
        /// </summary>
        public const string RDE74RA07 = "RDE74RA07";

        /// <summary>
        /// RDE74RA08.
        /// </summary>
        public const string RDE74RA08 = "RDE74RA08";

        /// <summary>
        /// RDE74RA09.
        /// </summary>
        public const string RDE74RA09 = "RDE74RA09";

        /// <summary>
        /// RDE74RA10.
        /// </summary>
        public const string RDE74RA10 = "RDE74RA10";

        /// <summary>
        /// RDE74RA11.
        /// </summary>
        public const string RDE74RA11 = "RDE74RA11";

        /// <summary>
        /// RDE74RA12.
        /// </summary>
        public const string RDE74RA12 = "RDE74RA12";

        /// <summary>
        /// RDE74RA13.
        /// </summary>
        public const string RDE74RA13 = "RDE74RA13";

        /// <summary>
        /// RDE74RA14.
        /// </summary>
        public const string RDE74RA14 = "RDE74RA14";

        /// <summary>
        /// RDE74RA15.
        /// </summary>
        public const string RDE74RA15 = "RDE74RA15";

        /// <summary>
        /// RDE74RA16.
        /// </summary>
        public const string RDE74RA16 = "RDE74RA16";

        /// <summary>
        /// RDE74RA17.
        /// </summary>
        public const string RDE74RA17 = "RDE74RA17";

        /// <summary>
        /// RDE74RA18.
        /// </summary>
        public const string RDE74RA18 = "RDE74RA18";

        /// <summary>
        /// RDE74RA19.
        /// </summary>
        public const string RDE74RA19 = "RDE74RA19";

        /// <summary>
        /// RDE74RA20.
        /// </summary>
        public const string RDE74RA20 = "RDE74RA20";

        /// <summary>
        /// RDE74ASEQ.
        /// </summary>
        public const string RDE74ASEQ = "RDE74ASEQ";

        /// <summary>
        /// RDE74IITO.
        /// </summary>
        public const string RDE74IITO = "RDE74IITO";

        /// <summary>
        /// RDE74TD.
        /// </summary>
        public const string RDE74TD = "RDE74TD";

        /// <summary>
        /// RDE74VIS.
        /// </summary>
        public const string RDE74VIS = "RDE74VIS";
    }

    /// <inheritdoc />
    public override string TableName => "F74UI90";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDJOBS", "RDJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("RDE74RENA", "RDE74RENA", JdeDataType.String, 40, true, true),
        new JdeField("RDE74RSN", "RDE74RSN", JdeDataType.Numeric, null, true, true),
        new JdeField("RDE74RRN", "RDE74RRN", JdeDataType.Numeric, null, true, true),
        new JdeField("RDE74LSEQ", "RDE74LSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RDE74RDES", "RDE74RDES", JdeDataType.String, 240),
        new JdeField("RDANI", "RDANI", JdeDataType.String, 58),
        new JdeField("RDPEC", "RDPEC", JdeDataType.String, 2),
        new JdeField("RDLDA", "RDLDA", JdeDataType.String, 2),
        new JdeField("RDE74GR1", "RDE74GR1", JdeDataType.String, 60),
        new JdeField("RDE74GR2", "RDE74GR2", JdeDataType.String, 60),
        new JdeField("RDE74GR3", "RDE74GR3", JdeDataType.String, 60),
        new JdeField("RDE74RA01", "RDE74RA01", JdeDataType.Numeric),
        new JdeField("RDE74RA02", "RDE74RA02", JdeDataType.Numeric),
        new JdeField("RDE74RA03", "RDE74RA03", JdeDataType.Numeric),
        new JdeField("RDE74RA04", "RDE74RA04", JdeDataType.Numeric),
        new JdeField("RDE74RA05", "RDE74RA05", JdeDataType.Numeric),
        new JdeField("RDE74RA06", "RDE74RA06", JdeDataType.Numeric),
        new JdeField("RDE74RA07", "RDE74RA07", JdeDataType.Numeric),
        new JdeField("RDE74RA08", "RDE74RA08", JdeDataType.Numeric),
        new JdeField("RDE74RA09", "RDE74RA09", JdeDataType.Numeric),
        new JdeField("RDE74RA10", "RDE74RA10", JdeDataType.Numeric),
        new JdeField("RDE74RA11", "RDE74RA11", JdeDataType.Numeric),
        new JdeField("RDE74RA12", "RDE74RA12", JdeDataType.Numeric),
        new JdeField("RDE74RA13", "RDE74RA13", JdeDataType.Numeric),
        new JdeField("RDE74RA14", "RDE74RA14", JdeDataType.Numeric),
        new JdeField("RDE74RA15", "RDE74RA15", JdeDataType.Numeric),
        new JdeField("RDE74RA16", "RDE74RA16", JdeDataType.Numeric),
        new JdeField("RDE74RA17", "RDE74RA17", JdeDataType.Numeric),
        new JdeField("RDE74RA18", "RDE74RA18", JdeDataType.Numeric),
        new JdeField("RDE74RA19", "RDE74RA19", JdeDataType.Numeric),
        new JdeField("RDE74RA20", "RDE74RA20", JdeDataType.Numeric),
        new JdeField("RDE74ASEQ", "RDE74ASEQ", JdeDataType.Numeric),
        new JdeField("RDE74IITO", "RDE74IITO", JdeDataType.String, 2),
        new JdeField("RDE74TD", "RDE74TD", JdeDataType.String, 2),
        new JdeField("RDE74VIS", "RDE74VIS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74UI90_0", "Primary Key on RDJOBS, RDE74RENA, RDE74RSN, RDE74RRN, RDE74LSEQ", new[] { "RDJOBS", "RDE74RENA", "RDE74RSN", "RDE74RRN", "RDE74LSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
