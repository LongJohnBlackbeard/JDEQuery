using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07353 - .
/// </summary>
public class F07353 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y3AN8.
        /// </summary>
        public const string Y3AN8 = "Y3AN8";

        /// <summary>
        /// Y3CKCN.
        /// </summary>
        public const string Y3CKCN = "Y3CKCN";

        /// <summary>
        /// Y3TARA.
        /// </summary>
        public const string Y3TARA = "Y3TARA";

        /// <summary>
        /// Y3PTAX.
        /// </summary>
        public const string Y3PTAX = "Y3PTAX";

        /// <summary>
        /// Y3PAYD.
        /// </summary>
        public const string Y3PAYD = "Y3PAYD";

        /// <summary>
        /// Y3WE01.
        /// </summary>
        public const string Y3WE01 = "Y3WE01";

        /// <summary>
        /// Y3WX01.
        /// </summary>
        public const string Y3WX01 = "Y3WX01";

        /// <summary>
        /// Y3G301.
        /// </summary>
        public const string Y3G301 = "Y3G301";

        /// <summary>
        /// Y3YTDT.
        /// </summary>
        public const string Y3YTDT = "Y3YTDT";

        /// <summary>
        /// Y3CE.
        /// </summary>
        public const string Y3CE = "Y3CE";

        /// <summary>
        /// Y3G101.
        /// </summary>
        public const string Y3G101 = "Y3G101";

        /// <summary>
        /// Y3YTDG.
        /// </summary>
        public const string Y3YTDG = "Y3YTDG";

        /// <summary>
        /// Y3TXOF.
        /// </summary>
        public const string Y3TXOF = "Y3TXOF";

        /// <summary>
        /// Y3FT01.
        /// </summary>
        public const string Y3FT01 = "Y3FT01";

        /// <summary>
        /// Y3CX01.
        /// </summary>
        public const string Y3CX01 = "Y3CX01";

        /// <summary>
        /// Y3XC01.
        /// </summary>
        public const string Y3XC01 = "Y3XC01";

        /// <summary>
        /// Y3G201.
        /// </summary>
        public const string Y3G201 = "Y3G201";

        /// <summary>
        /// Y3ACTF.
        /// </summary>
        public const string Y3ACTF = "Y3ACTF";

        /// <summary>
        /// Y3VREC.
        /// </summary>
        public const string Y3VREC = "Y3VREC";

        /// <summary>
        /// Y3RTAM.
        /// </summary>
        public const string Y3RTAM = "Y3RTAM";

        /// <summary>
        /// Y3RTAX.
        /// </summary>
        public const string Y3RTAX = "Y3RTAX";

        /// <summary>
        /// Y3HMCO.
        /// </summary>
        public const string Y3HMCO = "Y3HMCO";

        /// <summary>
        /// Y3TAXX.
        /// </summary>
        public const string Y3TAXX = "Y3TAXX";

        /// <summary>
        /// Y3DWK.
        /// </summary>
        public const string Y3DWK = "Y3DWK";

        /// <summary>
        /// Y3PPNB.
        /// </summary>
        public const string Y3PPNB = "Y3PPNB";

        /// <summary>
        /// Y3PPED.
        /// </summary>
        public const string Y3PPED = "Y3PPED";

        /// <summary>
        /// Y3CKDT.
        /// </summary>
        public const string Y3CKDT = "Y3CKDT";

        /// <summary>
        /// Y3UPMJ.
        /// </summary>
        public const string Y3UPMJ = "Y3UPMJ";

        /// <summary>
        /// Y3UPMT.
        /// </summary>
        public const string Y3UPMT = "Y3UPMT";

        /// <summary>
        /// Y3PID.
        /// </summary>
        public const string Y3PID = "Y3PID";

        /// <summary>
        /// Y3JOBN.
        /// </summary>
        public const string Y3JOBN = "Y3JOBN";

        /// <summary>
        /// Y3USER.
        /// </summary>
        public const string Y3USER = "Y3USER";
    }

    /// <inheritdoc />
    public override string TableName => "F07353";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y3AN8", "Y3AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Y3CKCN", "Y3CKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("Y3TARA", "Y3TARA", JdeDataType.String, 20, true, true),
        new JdeField("Y3PTAX", "Y3PTAX", JdeDataType.String, 4, true, true),
        new JdeField("Y3PAYD", "Y3PAYD", JdeDataType.String, 20),
        new JdeField("Y3WE01", "Y3WE01", JdeDataType.Numeric),
        new JdeField("Y3WX01", "Y3WX01", JdeDataType.Numeric),
        new JdeField("Y3G301", "Y3G301", JdeDataType.Numeric),
        new JdeField("Y3YTDT", "Y3YTDT", JdeDataType.Numeric),
        new JdeField("Y3CE", "Y3CE", JdeDataType.String, 2),
        new JdeField("Y3G101", "Y3G101", JdeDataType.Numeric),
        new JdeField("Y3YTDG", "Y3YTDG", JdeDataType.Numeric),
        new JdeField("Y3TXOF", "Y3TXOF", JdeDataType.String, 2),
        new JdeField("Y3FT01", "Y3FT01", JdeDataType.String, 2),
        new JdeField("Y3CX01", "Y3CX01", JdeDataType.Numeric),
        new JdeField("Y3XC01", "Y3XC01", JdeDataType.Numeric),
        new JdeField("Y3G201", "Y3G201", JdeDataType.Numeric),
        new JdeField("Y3ACTF", "Y3ACTF", JdeDataType.String, 8),
        new JdeField("Y3VREC", "Y3VREC", JdeDataType.String, 8),
        new JdeField("Y3RTAM", "Y3RTAM", JdeDataType.Numeric),
        new JdeField("Y3RTAX", "Y3RTAX", JdeDataType.Numeric),
        new JdeField("Y3HMCO", "Y3HMCO", JdeDataType.String, 10),
        new JdeField("Y3TAXX", "Y3TAXX", JdeDataType.String, 40),
        new JdeField("Y3DWK", "Y3DWK", JdeDataType.Numeric),
        new JdeField("Y3PPNB", "Y3PPNB", JdeDataType.String, 6),
        new JdeField("Y3PPED", "Y3PPED", JdeDataType.Numeric),
        new JdeField("Y3CKDT", "Y3CKDT", JdeDataType.Numeric),
        new JdeField("Y3UPMJ", "Y3UPMJ", JdeDataType.Numeric),
        new JdeField("Y3UPMT", "Y3UPMT", JdeDataType.Numeric),
        new JdeField("Y3PID", "Y3PID", JdeDataType.String, 20),
        new JdeField("Y3JOBN", "Y3JOBN", JdeDataType.String, 20),
        new JdeField("Y3USER", "Y3USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07353_0", "Primary Key on Y3AN8, Y3CKCN, Y3TARA, Y3PTAX", new[] { "Y3AN8", "Y3CKCN", "Y3TARA", "Y3PTAX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07353_2", "Index on Y3HMCO, Y3TARA, Y3PTAX", new[] { "Y3HMCO", "Y3TARA", "Y3PTAX" }),
        new JdeIndex("F07353_3", "Index on Y3PID", new[] { "Y3PID" })
    };
}
