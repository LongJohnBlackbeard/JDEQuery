using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS16 - .
/// </summary>
public class F54HS16 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDHSINO.
        /// </summary>
        public const string SDHSINO = "SDHSINO";

        /// <summary>
        /// SDHSIGP.
        /// </summary>
        public const string SDHSIGP = "SDHSIGP";

        /// <summary>
        /// SDHSIF01.
        /// </summary>
        public const string SDHSIF01 = "SDHSIF01";

        /// <summary>
        /// SDHSIF02.
        /// </summary>
        public const string SDHSIF02 = "SDHSIF02";

        /// <summary>
        /// SDHSIF03.
        /// </summary>
        public const string SDHSIF03 = "SDHSIF03";

        /// <summary>
        /// SDHSIF04.
        /// </summary>
        public const string SDHSIF04 = "SDHSIF04";

        /// <summary>
        /// SDHSIF05.
        /// </summary>
        public const string SDHSIF05 = "SDHSIF05";

        /// <summary>
        /// SDHSIF06.
        /// </summary>
        public const string SDHSIF06 = "SDHSIF06";

        /// <summary>
        /// SDHSIF07.
        /// </summary>
        public const string SDHSIF07 = "SDHSIF07";

        /// <summary>
        /// SDHSIF08.
        /// </summary>
        public const string SDHSIF08 = "SDHSIF08";

        /// <summary>
        /// SDHSIF09.
        /// </summary>
        public const string SDHSIF09 = "SDHSIF09";

        /// <summary>
        /// SDHSIF10.
        /// </summary>
        public const string SDHSIF10 = "SDHSIF10";

        /// <summary>
        /// SDHSIF11.
        /// </summary>
        public const string SDHSIF11 = "SDHSIF11";

        /// <summary>
        /// SDHSIF12.
        /// </summary>
        public const string SDHSIF12 = "SDHSIF12";

        /// <summary>
        /// SDHSIF13.
        /// </summary>
        public const string SDHSIF13 = "SDHSIF13";

        /// <summary>
        /// SDHSIF14.
        /// </summary>
        public const string SDHSIF14 = "SDHSIF14";

        /// <summary>
        /// SDHSIF15.
        /// </summary>
        public const string SDHSIF15 = "SDHSIF15";

        /// <summary>
        /// SDHSIF16.
        /// </summary>
        public const string SDHSIF16 = "SDHSIF16";

        /// <summary>
        /// SDHSIF17.
        /// </summary>
        public const string SDHSIF17 = "SDHSIF17";

        /// <summary>
        /// SDHSIF18.
        /// </summary>
        public const string SDHSIF18 = "SDHSIF18";

        /// <summary>
        /// SDHSIF19.
        /// </summary>
        public const string SDHSIF19 = "SDHSIF19";

        /// <summary>
        /// SDHSIF20.
        /// </summary>
        public const string SDHSIF20 = "SDHSIF20";

        /// <summary>
        /// SDHSIF21.
        /// </summary>
        public const string SDHSIF21 = "SDHSIF21";

        /// <summary>
        /// SDHSIF22.
        /// </summary>
        public const string SDHSIF22 = "SDHSIF22";

        /// <summary>
        /// SDHSIF23.
        /// </summary>
        public const string SDHSIF23 = "SDHSIF23";

        /// <summary>
        /// SDHSIF24.
        /// </summary>
        public const string SDHSIF24 = "SDHSIF24";

        /// <summary>
        /// SDHSIF25.
        /// </summary>
        public const string SDHSIF25 = "SDHSIF25";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";

        /// <summary>
        /// SDMKEY.
        /// </summary>
        public const string SDMKEY = "SDMKEY";

        /// <summary>
        /// SDENTJ.
        /// </summary>
        public const string SDENTJ = "SDENTJ";

        /// <summary>
        /// SDTORG.
        /// </summary>
        public const string SDTORG = "SDTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS16";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDHSINO", "SDHSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("SDHSIGP", "SDHSIGP", JdeDataType.String, 20, true, true),
        new JdeField("SDHSIF01", "SDHSIF01", JdeDataType.String, 100),
        new JdeField("SDHSIF02", "SDHSIF02", JdeDataType.String, 100),
        new JdeField("SDHSIF03", "SDHSIF03", JdeDataType.String, 100),
        new JdeField("SDHSIF04", "SDHSIF04", JdeDataType.String, 100),
        new JdeField("SDHSIF05", "SDHSIF05", JdeDataType.String, 100),
        new JdeField("SDHSIF06", "SDHSIF06", JdeDataType.String, 100),
        new JdeField("SDHSIF07", "SDHSIF07", JdeDataType.String, 100),
        new JdeField("SDHSIF08", "SDHSIF08", JdeDataType.String, 100),
        new JdeField("SDHSIF09", "SDHSIF09", JdeDataType.String, 100),
        new JdeField("SDHSIF10", "SDHSIF10", JdeDataType.String, 100),
        new JdeField("SDHSIF11", "SDHSIF11", JdeDataType.String, 100),
        new JdeField("SDHSIF12", "SDHSIF12", JdeDataType.String, 100),
        new JdeField("SDHSIF13", "SDHSIF13", JdeDataType.String, 100),
        new JdeField("SDHSIF14", "SDHSIF14", JdeDataType.String, 100),
        new JdeField("SDHSIF15", "SDHSIF15", JdeDataType.String, 100),
        new JdeField("SDHSIF16", "SDHSIF16", JdeDataType.String, 100),
        new JdeField("SDHSIF17", "SDHSIF17", JdeDataType.String, 100),
        new JdeField("SDHSIF18", "SDHSIF18", JdeDataType.String, 100),
        new JdeField("SDHSIF19", "SDHSIF19", JdeDataType.String, 100),
        new JdeField("SDHSIF20", "SDHSIF20", JdeDataType.String, 100),
        new JdeField("SDHSIF21", "SDHSIF21", JdeDataType.String, 400),
        new JdeField("SDHSIF22", "SDHSIF22", JdeDataType.String, 400),
        new JdeField("SDHSIF23", "SDHSIF23", JdeDataType.String, 400),
        new JdeField("SDHSIF24", "SDHSIF24", JdeDataType.String, 400),
        new JdeField("SDHSIF25", "SDHSIF25", JdeDataType.String, 400),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric),
        new JdeField("SDMKEY", "SDMKEY", JdeDataType.String, 30),
        new JdeField("SDENTJ", "SDENTJ", JdeDataType.Numeric),
        new JdeField("SDTORG", "SDTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS16_0", "Primary Key on SDHSINO, SDHSIGP", new[] { "SDHSINO", "SDHSIGP" }, isUnique: true, isPrimaryKey: true)
    };
}
