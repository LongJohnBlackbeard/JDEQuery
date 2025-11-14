using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07352 - .
/// </summary>
public class F07352 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y2CKCN.
        /// </summary>
        public const string Y2CKCN = "Y2CKCN";

        /// <summary>
        /// Y2STLN.
        /// </summary>
        public const string Y2STLN = "Y2STLN";

        /// <summary>
        /// Y2PDBA.
        /// </summary>
        public const string Y2PDBA = "Y2PDBA";

        /// <summary>
        /// Y2DISO.
        /// </summary>
        public const string Y2DISO = "Y2DISO";

        /// <summary>
        /// Y2DL01.
        /// </summary>
        public const string Y2DL01 = "Y2DL01";

        /// <summary>
        /// Y2HRW.
        /// </summary>
        public const string Y2HRW = "Y2HRW";

        /// <summary>
        /// Y2SHRT.
        /// </summary>
        public const string Y2SHRT = "Y2SHRT";

        /// <summary>
        /// Y2GPAY.
        /// </summary>
        public const string Y2GPAY = "Y2GPAY";

        /// <summary>
        /// Y2YTD.
        /// </summary>
        public const string Y2YTD = "Y2YTD";

        /// <summary>
        /// Y2DBAR.
        /// </summary>
        public const string Y2DBAR = "Y2DBAR";

        /// <summary>
        /// Y2PTAX.
        /// </summary>
        public const string Y2PTAX = "Y2PTAX";

        /// <summary>
        /// Y2TARA.
        /// </summary>
        public const string Y2TARA = "Y2TARA";

        /// <summary>
        /// Y2DL02.
        /// </summary>
        public const string Y2DL02 = "Y2DL02";

        /// <summary>
        /// Y2SCUR.
        /// </summary>
        public const string Y2SCUR = "Y2SCUR";

        /// <summary>
        /// Y2YTDG.
        /// </summary>
        public const string Y2YTDG = "Y2YTDG";

        /// <summary>
        /// Y2SACR.
        /// </summary>
        public const string Y2SACR = "Y2SACR";

        /// <summary>
        /// Y2SOVR.
        /// </summary>
        public const string Y2SOVR = "Y2SOVR";

        /// <summary>
        /// Y2UPMJ.
        /// </summary>
        public const string Y2UPMJ = "Y2UPMJ";

        /// <summary>
        /// Y2UPMT.
        /// </summary>
        public const string Y2UPMT = "Y2UPMT";

        /// <summary>
        /// Y2PID.
        /// </summary>
        public const string Y2PID = "Y2PID";

        /// <summary>
        /// Y2JOBN.
        /// </summary>
        public const string Y2JOBN = "Y2JOBN";

        /// <summary>
        /// Y2USER.
        /// </summary>
        public const string Y2USER = "Y2USER";
    }

    /// <inheritdoc />
    public override string TableName => "F07352";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y2CKCN", "Y2CKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("Y2STLN", "Y2STLN", JdeDataType.Numeric, null, true, true),
        new JdeField("Y2PDBA", "Y2PDBA", JdeDataType.Numeric),
        new JdeField("Y2DISO", "Y2DISO", JdeDataType.String, 2),
        new JdeField("Y2DL01", "Y2DL01", JdeDataType.String, 60),
        new JdeField("Y2HRW", "Y2HRW", JdeDataType.Numeric),
        new JdeField("Y2SHRT", "Y2SHRT", JdeDataType.Numeric),
        new JdeField("Y2GPAY", "Y2GPAY", JdeDataType.Numeric),
        new JdeField("Y2YTD", "Y2YTD", JdeDataType.Numeric),
        new JdeField("Y2DBAR", "Y2DBAR", JdeDataType.Numeric),
        new JdeField("Y2PTAX", "Y2PTAX", JdeDataType.String, 4),
        new JdeField("Y2TARA", "Y2TARA", JdeDataType.String, 20),
        new JdeField("Y2DL02", "Y2DL02", JdeDataType.String, 60),
        new JdeField("Y2SCUR", "Y2SCUR", JdeDataType.Numeric),
        new JdeField("Y2YTDG", "Y2YTDG", JdeDataType.Numeric),
        new JdeField("Y2SACR", "Y2SACR", JdeDataType.String, 2),
        new JdeField("Y2SOVR", "Y2SOVR", JdeDataType.String, 2),
        new JdeField("Y2UPMJ", "Y2UPMJ", JdeDataType.Numeric),
        new JdeField("Y2UPMT", "Y2UPMT", JdeDataType.Numeric),
        new JdeField("Y2PID", "Y2PID", JdeDataType.String, 20),
        new JdeField("Y2JOBN", "Y2JOBN", JdeDataType.String, 20),
        new JdeField("Y2USER", "Y2USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07352_0", "Primary Key on Y2CKCN, Y2STLN", new[] { "Y2CKCN", "Y2STLN" }, isUnique: true, isPrimaryKey: true)
    };
}
