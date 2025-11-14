using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5102 - .
/// </summary>
public class F5102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TKMCURPO.
        /// </summary>
        public const string TKMCURPO = "TKMCURPO";

        /// <summary>
        /// TKMCU.
        /// </summary>
        public const string TKMCU = "TKMCU";

        /// <summary>
        /// TKDC.
        /// </summary>
        public const string TKDC = "TKDC";

        /// <summary>
        /// TKDL01.
        /// </summary>
        public const string TKDL01 = "TKDL01";

        /// <summary>
        /// TKDL02.
        /// </summary>
        public const string TKDL02 = "TKDL02";

        /// <summary>
        /// TKDL03.
        /// </summary>
        public const string TKDL03 = "TKDL03";

        /// <summary>
        /// TKDL04.
        /// </summary>
        public const string TKDL04 = "TKDL04";

        /// <summary>
        /// TKRPO01.
        /// </summary>
        public const string TKRPO01 = "TKRPO01";

        /// <summary>
        /// TKRPO02.
        /// </summary>
        public const string TKRPO02 = "TKRPO02";

        /// <summary>
        /// TKRPO03.
        /// </summary>
        public const string TKRPO03 = "TKRPO03";

        /// <summary>
        /// TKRPO04.
        /// </summary>
        public const string TKRPO04 = "TKRPO04";

        /// <summary>
        /// TKRPO05.
        /// </summary>
        public const string TKRPO05 = "TKRPO05";

        /// <summary>
        /// TKRPO06.
        /// </summary>
        public const string TKRPO06 = "TKRPO06";

        /// <summary>
        /// TKRPO07.
        /// </summary>
        public const string TKRPO07 = "TKRPO07";

        /// <summary>
        /// TKRPO08.
        /// </summary>
        public const string TKRPO08 = "TKRPO08";

        /// <summary>
        /// TKRPO09.
        /// </summary>
        public const string TKRPO09 = "TKRPO09";

        /// <summary>
        /// TKRPO10.
        /// </summary>
        public const string TKRPO10 = "TKRPO10";

        /// <summary>
        /// TKRPFST.
        /// </summary>
        public const string TKRPFST = "TKRPFST";

        /// <summary>
        /// TKD1J.
        /// </summary>
        public const string TKD1J = "TKD1J";

        /// <summary>
        /// TKD3J.
        /// </summary>
        public const string TKD3J = "TKD3J";

        /// <summary>
        /// TKD2J.
        /// </summary>
        public const string TKD2J = "TKD2J";

        /// <summary>
        /// TKD4J.
        /// </summary>
        public const string TKD4J = "TKD4J";

        /// <summary>
        /// TKUDATE1.
        /// </summary>
        public const string TKUDATE1 = "TKUDATE1";

        /// <summary>
        /// TKUDATE2.
        /// </summary>
        public const string TKUDATE2 = "TKUDATE2";

        /// <summary>
        /// TKAN8.
        /// </summary>
        public const string TKAN8 = "TKAN8";

        /// <summary>
        /// TKAN8GCA1.
        /// </summary>
        public const string TKAN8GCA1 = "TKAN8GCA1";

        /// <summary>
        /// TKAN8GCA2.
        /// </summary>
        public const string TKAN8GCA2 = "TKAN8GCA2";

        /// <summary>
        /// TKAN8GCA3.
        /// </summary>
        public const string TKAN8GCA3 = "TKAN8GCA3";

        /// <summary>
        /// TKAN8GCA4.
        /// </summary>
        public const string TKAN8GCA4 = "TKAN8GCA4";

        /// <summary>
        /// TKUPMJ.
        /// </summary>
        public const string TKUPMJ = "TKUPMJ";

        /// <summary>
        /// TKUPMT.
        /// </summary>
        public const string TKUPMT = "TKUPMT";

        /// <summary>
        /// TKUSER.
        /// </summary>
        public const string TKUSER = "TKUSER";

        /// <summary>
        /// TKPID.
        /// </summary>
        public const string TKPID = "TKPID";

        /// <summary>
        /// TKJOBN.
        /// </summary>
        public const string TKJOBN = "TKJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F5102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TKMCURPO", "TKMCURPO", JdeDataType.String, 16, true, true),
        new JdeField("TKMCU", "TKMCU", JdeDataType.String, 24),
        new JdeField("TKDC", "TKDC", JdeDataType.String, 80),
        new JdeField("TKDL01", "TKDL01", JdeDataType.String, 60),
        new JdeField("TKDL02", "TKDL02", JdeDataType.String, 60),
        new JdeField("TKDL03", "TKDL03", JdeDataType.String, 60),
        new JdeField("TKDL04", "TKDL04", JdeDataType.String, 60),
        new JdeField("TKRPO01", "TKRPO01", JdeDataType.String, 20),
        new JdeField("TKRPO02", "TKRPO02", JdeDataType.String, 20),
        new JdeField("TKRPO03", "TKRPO03", JdeDataType.String, 20),
        new JdeField("TKRPO04", "TKRPO04", JdeDataType.String, 20),
        new JdeField("TKRPO05", "TKRPO05", JdeDataType.String, 20),
        new JdeField("TKRPO06", "TKRPO06", JdeDataType.String, 20),
        new JdeField("TKRPO07", "TKRPO07", JdeDataType.String, 20),
        new JdeField("TKRPO08", "TKRPO08", JdeDataType.String, 20),
        new JdeField("TKRPO09", "TKRPO09", JdeDataType.String, 20),
        new JdeField("TKRPO10", "TKRPO10", JdeDataType.String, 20),
        new JdeField("TKRPFST", "TKRPFST", JdeDataType.Numeric),
        new JdeField("TKD1J", "TKD1J", JdeDataType.Numeric),
        new JdeField("TKD3J", "TKD3J", JdeDataType.Numeric),
        new JdeField("TKD2J", "TKD2J", JdeDataType.Numeric),
        new JdeField("TKD4J", "TKD4J", JdeDataType.Numeric),
        new JdeField("TKUDATE1", "TKUDATE1", JdeDataType.Numeric),
        new JdeField("TKUDATE2", "TKUDATE2", JdeDataType.Numeric),
        new JdeField("TKAN8", "TKAN8", JdeDataType.Numeric),
        new JdeField("TKAN8GCA1", "TKAN8GCA1", JdeDataType.Numeric),
        new JdeField("TKAN8GCA2", "TKAN8GCA2", JdeDataType.Numeric),
        new JdeField("TKAN8GCA3", "TKAN8GCA3", JdeDataType.Numeric),
        new JdeField("TKAN8GCA4", "TKAN8GCA4", JdeDataType.Numeric),
        new JdeField("TKUPMJ", "TKUPMJ", JdeDataType.Numeric),
        new JdeField("TKUPMT", "TKUPMT", JdeDataType.Numeric),
        new JdeField("TKUSER", "TKUSER", JdeDataType.String, 20),
        new JdeField("TKPID", "TKPID", JdeDataType.String, 20),
        new JdeField("TKJOBN", "TKJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5102_0", "Primary Key on TKMCURPO", new[] { "TKMCURPO" }, isUnique: true, isPrimaryKey: true)
    };
}
