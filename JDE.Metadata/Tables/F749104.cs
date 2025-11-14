using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F749104 - .
/// </summary>
public class F749104 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
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
        /// RDE74ROWT.
        /// </summary>
        public const string RDE74ROWT = "RDE74ROWT";

        /// <summary>
        /// RDE74RDES.
        /// </summary>
        public const string RDE74RDES = "RDE74RDES";

        /// <summary>
        /// RDE74ACCG.
        /// </summary>
        public const string RDE74ACCG = "RDE74ACCG";

        /// <summary>
        /// RDE74MCUG.
        /// </summary>
        public const string RDE74MCUG = "RDE74MCUG";

        /// <summary>
        /// RDE74VIS.
        /// </summary>
        public const string RDE74VIS = "RDE74VIS";

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
        /// RDE74SAD.
        /// </summary>
        public const string RDE74SAD = "RDE74SAD";

        /// <summary>
        /// RDE74ACLE.
        /// </summary>
        public const string RDE74ACLE = "RDE74ACLE";

        /// <summary>
        /// RDE74RA1.
        /// </summary>
        public const string RDE74RA1 = "RDE74RA1";

        /// <summary>
        /// RDE74RA2.
        /// </summary>
        public const string RDE74RA2 = "RDE74RA2";

        /// <summary>
        /// RDE74RA3.
        /// </summary>
        public const string RDE74RA3 = "RDE74RA3";

        /// <summary>
        /// RDANI.
        /// </summary>
        public const string RDANI = "RDANI";

        /// <summary>
        /// RDAID.
        /// </summary>
        public const string RDAID = "RDAID";

        /// <summary>
        /// RDE74ST1S.
        /// </summary>
        public const string RDE74ST1S = "RDE74ST1S";

        /// <summary>
        /// RDE74ST2S.
        /// </summary>
        public const string RDE74ST2S = "RDE74ST2S";

        /// <summary>
        /// RDE74ST3S.
        /// </summary>
        public const string RDE74ST3S = "RDE74ST3S";

        /// <summary>
        /// RDE74TD1S.
        /// </summary>
        public const string RDE74TD1S = "RDE74TD1S";

        /// <summary>
        /// RDE74TD2S.
        /// </summary>
        public const string RDE74TD2S = "RDE74TD2S";

        /// <summary>
        /// RDE74TD3S.
        /// </summary>
        public const string RDE74TD3S = "RDE74TD3S";

        /// <summary>
        /// RDE74LIAF.
        /// </summary>
        public const string RDE74LIAF = "RDE74LIAF";

        /// <summary>
        /// RDE74IITO.
        /// </summary>
        public const string RDE74IITO = "RDE74IITO";

        /// <summary>
        /// RDE74FORM.
        /// </summary>
        public const string RDE74FORM = "RDE74FORM";

        /// <summary>
        /// RDE74FACT.
        /// </summary>
        public const string RDE74FACT = "RDE74FACT";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDUPMT.
        /// </summary>
        public const string RDUPMT = "RDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F749104";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDE74RENA", "RDE74RENA", JdeDataType.String, 40, true, true),
        new JdeField("RDE74RSN", "RDE74RSN", JdeDataType.Numeric, null, true, true),
        new JdeField("RDE74RRN", "RDE74RRN", JdeDataType.Numeric, null, true, true),
        new JdeField("RDE74ROWT", "RDE74ROWT", JdeDataType.String, 6),
        new JdeField("RDE74RDES", "RDE74RDES", JdeDataType.String, 240),
        new JdeField("RDE74ACCG", "RDE74ACCG", JdeDataType.String, 30),
        new JdeField("RDE74MCUG", "RDE74MCUG", JdeDataType.String, 30),
        new JdeField("RDE74VIS", "RDE74VIS", JdeDataType.String, 2),
        new JdeField("RDE74GR1", "RDE74GR1", JdeDataType.String, 60),
        new JdeField("RDE74GR2", "RDE74GR2", JdeDataType.String, 60),
        new JdeField("RDE74GR3", "RDE74GR3", JdeDataType.String, 60),
        new JdeField("RDE74SAD", "RDE74SAD", JdeDataType.String, 2),
        new JdeField("RDE74ACLE", "RDE74ACLE", JdeDataType.String, 2),
        new JdeField("RDE74RA1", "RDE74RA1", JdeDataType.String, 20),
        new JdeField("RDE74RA2", "RDE74RA2", JdeDataType.String, 20),
        new JdeField("RDE74RA3", "RDE74RA3", JdeDataType.String, 20),
        new JdeField("RDANI", "RDANI", JdeDataType.String, 58),
        new JdeField("RDAID", "RDAID", JdeDataType.String, 16),
        new JdeField("RDE74ST1S", "RDE74ST1S", JdeDataType.String, 2),
        new JdeField("RDE74ST2S", "RDE74ST2S", JdeDataType.String, 2),
        new JdeField("RDE74ST3S", "RDE74ST3S", JdeDataType.String, 2),
        new JdeField("RDE74TD1S", "RDE74TD1S", JdeDataType.String, 58),
        new JdeField("RDE74TD2S", "RDE74TD2S", JdeDataType.String, 58),
        new JdeField("RDE74TD3S", "RDE74TD3S", JdeDataType.String, 58),
        new JdeField("RDE74LIAF", "RDE74LIAF", JdeDataType.Numeric),
        new JdeField("RDE74IITO", "RDE74IITO", JdeDataType.String, 2),
        new JdeField("RDE74FORM", "RDE74FORM", JdeDataType.String, 480),
        new JdeField("RDE74FACT", "RDE74FACT", JdeDataType.String, 2),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDUPMT", "RDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F749104_0", "Primary Key on RDE74RENA, RDE74RSN, RDE74RRN", new[] { "RDE74RENA", "RDE74RSN", "RDE74RRN" }, isUnique: true, isPrimaryKey: true)
    };
}
