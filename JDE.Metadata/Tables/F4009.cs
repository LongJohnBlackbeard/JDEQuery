using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4009 - .
/// </summary>
public class F4009 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CPSY.
        /// </summary>
        public const string CPSY = "CPSY";

        /// <summary>
        /// CPBUMC.
        /// </summary>
        public const string CPBUMC = "CPBUMC";

        /// <summary>
        /// CPBSDB.
        /// </summary>
        public const string CPBSDB = "CPBSDB";

        /// <summary>
        /// CPULOT.
        /// </summary>
        public const string CPULOT = "CPULOT";

        /// <summary>
        /// CPAVGC.
        /// </summary>
        public const string CPAVGC = "CPAVGC";

        /// <summary>
        /// CPADVP.
        /// </summary>
        public const string CPADVP = "CPADVP";

        /// <summary>
        /// CPUMB1.
        /// </summary>
        public const string CPUMB1 = "CPUMB1";

        /// <summary>
        /// CPCP01.
        /// </summary>
        public const string CPCP01 = "CPCP01";

        /// <summary>
        /// CPCP02.
        /// </summary>
        public const string CPCP02 = "CPCP02";

        /// <summary>
        /// CPCP03.
        /// </summary>
        public const string CPCP03 = "CPCP03";

        /// <summary>
        /// CPCP04.
        /// </summary>
        public const string CPCP04 = "CPCP04";

        /// <summary>
        /// CPCP05.
        /// </summary>
        public const string CPCP05 = "CPCP05";

        /// <summary>
        /// CPCP06.
        /// </summary>
        public const string CPCP06 = "CPCP06";

        /// <summary>
        /// CPCP07.
        /// </summary>
        public const string CPCP07 = "CPCP07";

        /// <summary>
        /// CPCP08.
        /// </summary>
        public const string CPCP08 = "CPCP08";

        /// <summary>
        /// CPCP09.
        /// </summary>
        public const string CPCP09 = "CPCP09";

        /// <summary>
        /// CPCP10.
        /// </summary>
        public const string CPCP10 = "CPCP10";

        /// <summary>
        /// CPCCTL.
        /// </summary>
        public const string CPCCTL = "CPCCTL";

        /// <summary>
        /// CPSADR.
        /// </summary>
        public const string CPSADR = "CPSADR";

        /// <summary>
        /// CPCP11.
        /// </summary>
        public const string CPCP11 = "CPCP11";

        /// <summary>
        /// CPCP12.
        /// </summary>
        public const string CPCP12 = "CPCP12";

        /// <summary>
        /// CPCP13.
        /// </summary>
        public const string CPCP13 = "CPCP13";

        /// <summary>
        /// CPCP14.
        /// </summary>
        public const string CPCP14 = "CPCP14";

        /// <summary>
        /// CPCP15.
        /// </summary>
        public const string CPCP15 = "CPCP15";

        /// <summary>
        /// CPCP16.
        /// </summary>
        public const string CPCP16 = "CPCP16";

        /// <summary>
        /// CPCP17.
        /// </summary>
        public const string CPCP17 = "CPCP17";

        /// <summary>
        /// CPCP18.
        /// </summary>
        public const string CPCP18 = "CPCP18";

        /// <summary>
        /// CPCP19.
        /// </summary>
        public const string CPCP19 = "CPCP19";

        /// <summary>
        /// CPCP20.
        /// </summary>
        public const string CPCP20 = "CPCP20";

        /// <summary>
        /// CPCHDC.
        /// </summary>
        public const string CPCHDC = "CPCHDC";

        /// <summary>
        /// CPELOT.
        /// </summary>
        public const string CPELOT = "CPELOT";

        /// <summary>
        /// CPAJRM.
        /// </summary>
        public const string CPAJRM = "CPAJRM";

        /// <summary>
        /// CPOSTP.
        /// </summary>
        public const string CPOSTP = "CPOSTP";

        /// <summary>
        /// CPPRAD.
        /// </summary>
        public const string CPPRAD = "CPPRAD";

        /// <summary>
        /// CPCP22.
        /// </summary>
        public const string CPCP22 = "CPCP22";

        /// <summary>
        /// CPPRSN.
        /// </summary>
        public const string CPPRSN = "CPPRSN";

        /// <summary>
        /// CPPMRF.
        /// </summary>
        public const string CPPMRF = "CPPMRF";

        /// <summary>
        /// CPPRSF.
        /// </summary>
        public const string CPPRSF = "CPPRSF";

        /// <summary>
        /// CPCP23.
        /// </summary>
        public const string CPCP23 = "CPCP23";

        /// <summary>
        /// CPCP24.
        /// </summary>
        public const string CPCP24 = "CPCP24";

        /// <summary>
        /// CPCP25.
        /// </summary>
        public const string CPCP25 = "CPCP25";

        /// <summary>
        /// CPCP26.
        /// </summary>
        public const string CPCP26 = "CPCP26";

        /// <summary>
        /// CPCP27.
        /// </summary>
        public const string CPCP27 = "CPCP27";

        /// <summary>
        /// CPCP28.
        /// </summary>
        public const string CPCP28 = "CPCP28";

        /// <summary>
        /// CPCP29.
        /// </summary>
        public const string CPCP29 = "CPCP29";

        /// <summary>
        /// CPCP30.
        /// </summary>
        public const string CPCP30 = "CPCP30";

        /// <summary>
        /// CPCP31.
        /// </summary>
        public const string CPCP31 = "CPCP31";

        /// <summary>
        /// CPCP32.
        /// </summary>
        public const string CPCP32 = "CPCP32";

        /// <summary>
        /// CPCP33.
        /// </summary>
        public const string CPCP33 = "CPCP33";

        /// <summary>
        /// CPCP34.
        /// </summary>
        public const string CPCP34 = "CPCP34";
    }

    /// <inheritdoc />
    public override string TableName => "F4009";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CPSY", "CPSY", JdeDataType.String, 8, true, true),
        new JdeField("CPBUMC", "CPBUMC", JdeDataType.String, 2),
        new JdeField("CPBSDB", "CPBSDB", JdeDataType.String, 2),
        new JdeField("CPULOT", "CPULOT", JdeDataType.String, 2),
        new JdeField("CPAVGC", "CPAVGC", JdeDataType.String, 2),
        new JdeField("CPADVP", "CPADVP", JdeDataType.String, 2),
        new JdeField("CPUMB1", "CPUMB1", JdeDataType.String, 2),
        new JdeField("CPCP01", "CPCP01", JdeDataType.String, 2),
        new JdeField("CPCP02", "CPCP02", JdeDataType.String, 2),
        new JdeField("CPCP03", "CPCP03", JdeDataType.String, 2),
        new JdeField("CPCP04", "CPCP04", JdeDataType.String, 2),
        new JdeField("CPCP05", "CPCP05", JdeDataType.String, 2),
        new JdeField("CPCP06", "CPCP06", JdeDataType.String, 2),
        new JdeField("CPCP07", "CPCP07", JdeDataType.String, 2),
        new JdeField("CPCP08", "CPCP08", JdeDataType.String, 2),
        new JdeField("CPCP09", "CPCP09", JdeDataType.String, 2),
        new JdeField("CPCP10", "CPCP10", JdeDataType.String, 2),
        new JdeField("CPCCTL", "CPCCTL", JdeDataType.String, 2),
        new JdeField("CPSADR", "CPSADR", JdeDataType.String, 2),
        new JdeField("CPCP11", "CPCP11", JdeDataType.String, 2),
        new JdeField("CPCP12", "CPCP12", JdeDataType.String, 2),
        new JdeField("CPCP13", "CPCP13", JdeDataType.String, 2),
        new JdeField("CPCP14", "CPCP14", JdeDataType.String, 2),
        new JdeField("CPCP15", "CPCP15", JdeDataType.String, 2),
        new JdeField("CPCP16", "CPCP16", JdeDataType.String, 2),
        new JdeField("CPCP17", "CPCP17", JdeDataType.String, 2),
        new JdeField("CPCP18", "CPCP18", JdeDataType.String, 2),
        new JdeField("CPCP19", "CPCP19", JdeDataType.String, 2),
        new JdeField("CPCP20", "CPCP20", JdeDataType.String, 2),
        new JdeField("CPCHDC", "CPCHDC", JdeDataType.String, 2),
        new JdeField("CPELOT", "CPELOT", JdeDataType.String, 2),
        new JdeField("CPAJRM", "CPAJRM", JdeDataType.String, 2),
        new JdeField("CPOSTP", "CPOSTP", JdeDataType.String, 6),
        new JdeField("CPPRAD", "CPPRAD", JdeDataType.String, 2),
        new JdeField("CPCP22", "CPCP22", JdeDataType.String, 2),
        new JdeField("CPPRSN", "CPPRSN", JdeDataType.String, 16),
        new JdeField("CPPMRF", "CPPMRF", JdeDataType.String, 2),
        new JdeField("CPPRSF", "CPPRSF", JdeDataType.String, 2),
        new JdeField("CPCP23", "CPCP23", JdeDataType.String, 2),
        new JdeField("CPCP24", "CPCP24", JdeDataType.String, 2),
        new JdeField("CPCP25", "CPCP25", JdeDataType.String, 2),
        new JdeField("CPCP26", "CPCP26", JdeDataType.String, 2),
        new JdeField("CPCP27", "CPCP27", JdeDataType.String, 2),
        new JdeField("CPCP28", "CPCP28", JdeDataType.String, 2),
        new JdeField("CPCP29", "CPCP29", JdeDataType.String, 2),
        new JdeField("CPCP30", "CPCP30", JdeDataType.String, 2),
        new JdeField("CPCP31", "CPCP31", JdeDataType.String, 2),
        new JdeField("CPCP32", "CPCP32", JdeDataType.String, 2),
        new JdeField("CPCP33", "CPCP33", JdeDataType.String, 2),
        new JdeField("CPCP34", "CPCP34", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4009_0", "Primary Key on CPSY", new[] { "CPSY" }, isUnique: true, isPrimaryKey: true)
    };
}
