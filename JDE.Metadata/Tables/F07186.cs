using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07186 - .
/// </summary>
public class F07186 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y8CKCN.
        /// </summary>
        public const string Y8CKCN = "Y8CKCN";

        /// <summary>
        /// Y8STLN.
        /// </summary>
        public const string Y8STLN = "Y8STLN";

        /// <summary>
        /// Y8PDBA.
        /// </summary>
        public const string Y8PDBA = "Y8PDBA";

        /// <summary>
        /// Y8DISO.
        /// </summary>
        public const string Y8DISO = "Y8DISO";

        /// <summary>
        /// Y8DL01.
        /// </summary>
        public const string Y8DL01 = "Y8DL01";

        /// <summary>
        /// Y8HRW.
        /// </summary>
        public const string Y8HRW = "Y8HRW";

        /// <summary>
        /// Y8SHRT.
        /// </summary>
        public const string Y8SHRT = "Y8SHRT";

        /// <summary>
        /// Y8GPAY.
        /// </summary>
        public const string Y8GPAY = "Y8GPAY";

        /// <summary>
        /// Y8YTD.
        /// </summary>
        public const string Y8YTD = "Y8YTD";

        /// <summary>
        /// Y8DBAR.
        /// </summary>
        public const string Y8DBAR = "Y8DBAR";

        /// <summary>
        /// Y8PTAX.
        /// </summary>
        public const string Y8PTAX = "Y8PTAX";

        /// <summary>
        /// Y8TARA.
        /// </summary>
        public const string Y8TARA = "Y8TARA";

        /// <summary>
        /// Y8DL02.
        /// </summary>
        public const string Y8DL02 = "Y8DL02";

        /// <summary>
        /// Y8SCUR.
        /// </summary>
        public const string Y8SCUR = "Y8SCUR";

        /// <summary>
        /// Y8YTDG.
        /// </summary>
        public const string Y8YTDG = "Y8YTDG";

        /// <summary>
        /// Y8SACR.
        /// </summary>
        public const string Y8SACR = "Y8SACR";

        /// <summary>
        /// Y8SOVR.
        /// </summary>
        public const string Y8SOVR = "Y8SOVR";

        /// <summary>
        /// Y8UPMJ.
        /// </summary>
        public const string Y8UPMJ = "Y8UPMJ";

        /// <summary>
        /// Y8UPMT.
        /// </summary>
        public const string Y8UPMT = "Y8UPMT";

        /// <summary>
        /// Y8PID.
        /// </summary>
        public const string Y8PID = "Y8PID";

        /// <summary>
        /// Y8JOBN.
        /// </summary>
        public const string Y8JOBN = "Y8JOBN";

        /// <summary>
        /// Y8USER.
        /// </summary>
        public const string Y8USER = "Y8USER";
    }

    /// <inheritdoc />
    public override string TableName => "F07186";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y8CKCN", "Y8CKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("Y8STLN", "Y8STLN", JdeDataType.Numeric, null, true, true),
        new JdeField("Y8PDBA", "Y8PDBA", JdeDataType.Numeric),
        new JdeField("Y8DISO", "Y8DISO", JdeDataType.String, 2),
        new JdeField("Y8DL01", "Y8DL01", JdeDataType.String, 60),
        new JdeField("Y8HRW", "Y8HRW", JdeDataType.Numeric),
        new JdeField("Y8SHRT", "Y8SHRT", JdeDataType.Numeric),
        new JdeField("Y8GPAY", "Y8GPAY", JdeDataType.Numeric),
        new JdeField("Y8YTD", "Y8YTD", JdeDataType.Numeric),
        new JdeField("Y8DBAR", "Y8DBAR", JdeDataType.Numeric),
        new JdeField("Y8PTAX", "Y8PTAX", JdeDataType.String, 4),
        new JdeField("Y8TARA", "Y8TARA", JdeDataType.String, 20),
        new JdeField("Y8DL02", "Y8DL02", JdeDataType.String, 60),
        new JdeField("Y8SCUR", "Y8SCUR", JdeDataType.Numeric),
        new JdeField("Y8YTDG", "Y8YTDG", JdeDataType.Numeric),
        new JdeField("Y8SACR", "Y8SACR", JdeDataType.String, 2),
        new JdeField("Y8SOVR", "Y8SOVR", JdeDataType.String, 2),
        new JdeField("Y8UPMJ", "Y8UPMJ", JdeDataType.Numeric),
        new JdeField("Y8UPMT", "Y8UPMT", JdeDataType.Numeric),
        new JdeField("Y8PID", "Y8PID", JdeDataType.String, 20),
        new JdeField("Y8JOBN", "Y8JOBN", JdeDataType.String, 20),
        new JdeField("Y8USER", "Y8USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07186_0", "Primary Key on Y8CKCN, Y8STLN", new[] { "Y8CKCN", "Y8STLN" }, isUnique: true, isPrimaryKey: true)
    };
}
