using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T0091 - .
/// </summary>
public class F75T0091 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDAN8.
        /// </summary>
        public const string SDAN8 = "SDAN8";

        /// <summary>
        /// SD75TVUN.
        /// </summary>
        public const string SD75TVUN = "SD75TVUN";

        /// <summary>
        /// SD75TGFC.
        /// </summary>
        public const string SD75TGFC = "SD75TGFC";

        /// <summary>
        /// SD75TIBF.
        /// </summary>
        public const string SD75TIBF = "SD75TIBF";

        /// <summary>
        /// SD75TFCW.
        /// </summary>
        public const string SD75TFCW = "SD75TFCW";

        /// <summary>
        /// SD75TPIT.
        /// </summary>
        public const string SD75TPIT = "SD75TPIT";

        /// <summary>
        /// SD75TDDC.
        /// </summary>
        public const string SD75TDDC = "SD75TDDC";

        /// <summary>
        /// SD75TIIT.
        /// </summary>
        public const string SD75TIIT = "SD75TIIT";

        /// <summary>
        /// SD75TPUS.
        /// </summary>
        public const string SD75TPUS = "SD75TPUS";

        /// <summary>
        /// SD75TCC7.
        /// </summary>
        public const string SD75TCC7 = "SD75TCC7";

        /// <summary>
        /// SD75TCC8.
        /// </summary>
        public const string SD75TCC8 = "SD75TCC8";

        /// <summary>
        /// SD75TCC9.
        /// </summary>
        public const string SD75TCC9 = "SD75TCC9";

        /// <summary>
        /// SDURC1.
        /// </summary>
        public const string SDURC1 = "SDURC1";

        /// <summary>
        /// SDURDT.
        /// </summary>
        public const string SDURDT = "SDURDT";

        /// <summary>
        /// SDURAT.
        /// </summary>
        public const string SDURAT = "SDURAT";

        /// <summary>
        /// SDURAB.
        /// </summary>
        public const string SDURAB = "SDURAB";

        /// <summary>
        /// SDURRF.
        /// </summary>
        public const string SDURRF = "SDURRF";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDTDAY.
        /// </summary>
        public const string SDTDAY = "SDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T0091";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDAN8", "SDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SD75TVUN", "SD75TVUN", JdeDataType.String, 16),
        new JdeField("SD75TGFC", "SD75TGFC", JdeDataType.String, 4),
        new JdeField("SD75TIBF", "SD75TIBF", JdeDataType.String, 2),
        new JdeField("SD75TFCW", "SD75TFCW", JdeDataType.String, 2),
        new JdeField("SD75TPIT", "SD75TPIT", JdeDataType.String, 6),
        new JdeField("SD75TDDC", "SD75TDDC", JdeDataType.String, 2),
        new JdeField("SD75TIIT", "SD75TIIT", JdeDataType.String, 6),
        new JdeField("SD75TPUS", "SD75TPUS", JdeDataType.String, 6),
        new JdeField("SD75TCC7", "SD75TCC7", JdeDataType.String, 6),
        new JdeField("SD75TCC8", "SD75TCC8", JdeDataType.String, 6),
        new JdeField("SD75TCC9", "SD75TCC9", JdeDataType.String, 6),
        new JdeField("SDURC1", "SDURC1", JdeDataType.String, 6),
        new JdeField("SDURDT", "SDURDT", JdeDataType.Numeric),
        new JdeField("SDURAT", "SDURAT", JdeDataType.Numeric),
        new JdeField("SDURAB", "SDURAB", JdeDataType.Numeric),
        new JdeField("SDURRF", "SDURRF", JdeDataType.String, 30),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDTDAY", "SDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T0091_0", "Primary Key on SDAN8", new[] { "SDAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75T0091_2", "Index on SD75TVUN", new[] { "SD75TVUN" })
    };
}
