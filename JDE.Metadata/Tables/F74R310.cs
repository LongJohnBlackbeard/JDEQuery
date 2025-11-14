using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R310 - .
/// </summary>
public class F74R310 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HEDCT.
        /// </summary>
        public const string HEDCT = "HEDCT";

        /// <summary>
        /// HEDOC.
        /// </summary>
        public const string HEDOC = "HEDOC";

        /// <summary>
        /// HEKCO.
        /// </summary>
        public const string HEKCO = "HEKCO";

        /// <summary>
        /// HER74LRN.
        /// </summary>
        public const string HER74LRN = "HER74LRN";

        /// <summary>
        /// HER74TP.
        /// </summary>
        public const string HER74TP = "HER74TP";

        /// <summary>
        /// HER74ATA.
        /// </summary>
        public const string HER74ATA = "HER74ATA";

        /// <summary>
        /// HER74ITA.
        /// </summary>
        public const string HER74ITA = "HER74ITA";

        /// <summary>
        /// HER74FTP.
        /// </summary>
        public const string HER74FTP = "HER74FTP";

        /// <summary>
        /// HER74FAT.
        /// </summary>
        public const string HER74FAT = "HER74FAT";

        /// <summary>
        /// HER74FIT.
        /// </summary>
        public const string HER74FIT = "HER74FIT";

        /// <summary>
        /// HEATXA.
        /// </summary>
        public const string HEATXA = "HEATXA";

        /// <summary>
        /// HER74AAT.
        /// </summary>
        public const string HER74AAT = "HER74AAT";

        /// <summary>
        /// HER74AIT.
        /// </summary>
        public const string HER74AIT = "HER74AIT";

        /// <summary>
        /// HECTXA.
        /// </summary>
        public const string HECTXA = "HECTXA";

        /// <summary>
        /// HER74AFT.
        /// </summary>
        public const string HER74AFT = "HER74AFT";

        /// <summary>
        /// HER74IFT.
        /// </summary>
        public const string HER74IFT = "HER74IFT";

        /// <summary>
        /// HEPID.
        /// </summary>
        public const string HEPID = "HEPID";

        /// <summary>
        /// HEJOBN.
        /// </summary>
        public const string HEJOBN = "HEJOBN";

        /// <summary>
        /// HEUSER.
        /// </summary>
        public const string HEUSER = "HEUSER";

        /// <summary>
        /// HEUPMJ.
        /// </summary>
        public const string HEUPMJ = "HEUPMJ";

        /// <summary>
        /// HEUPMT.
        /// </summary>
        public const string HEUPMT = "HEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R310";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HEDCT", "HEDCT", JdeDataType.String, 4, true, true),
        new JdeField("HEDOC", "HEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("HEKCO", "HEKCO", JdeDataType.String, 10, true, true),
        new JdeField("HER74LRN", "HER74LRN", JdeDataType.Numeric),
        new JdeField("HER74TP", "HER74TP", JdeDataType.Numeric),
        new JdeField("HER74ATA", "HER74ATA", JdeDataType.Numeric),
        new JdeField("HER74ITA", "HER74ITA", JdeDataType.Numeric),
        new JdeField("HER74FTP", "HER74FTP", JdeDataType.Numeric),
        new JdeField("HER74FAT", "HER74FAT", JdeDataType.Numeric),
        new JdeField("HER74FIT", "HER74FIT", JdeDataType.Numeric),
        new JdeField("HEATXA", "HEATXA", JdeDataType.Numeric),
        new JdeField("HER74AAT", "HER74AAT", JdeDataType.Numeric),
        new JdeField("HER74AIT", "HER74AIT", JdeDataType.Numeric),
        new JdeField("HECTXA", "HECTXA", JdeDataType.Numeric),
        new JdeField("HER74AFT", "HER74AFT", JdeDataType.Numeric),
        new JdeField("HER74IFT", "HER74IFT", JdeDataType.Numeric),
        new JdeField("HEPID", "HEPID", JdeDataType.String, 20),
        new JdeField("HEJOBN", "HEJOBN", JdeDataType.String, 20),
        new JdeField("HEUSER", "HEUSER", JdeDataType.String, 20),
        new JdeField("HEUPMJ", "HEUPMJ", JdeDataType.Numeric),
        new JdeField("HEUPMT", "HEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R310_0", "Primary Key on HEKCO, HEDCT, HEDOC", new[] { "HEKCO", "HEDCT", "HEDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
