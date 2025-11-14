using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R410 - .
/// </summary>
public class F74R410 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// THKCO.
        /// </summary>
        public const string THKCO = "THKCO";

        /// <summary>
        /// THDCT.
        /// </summary>
        public const string THDCT = "THDCT";

        /// <summary>
        /// THDOC.
        /// </summary>
        public const string THDOC = "THDOC";

        /// <summary>
        /// THTXA1.
        /// </summary>
        public const string THTXA1 = "THTXA1";

        /// <summary>
        /// THR74LRN.
        /// </summary>
        public const string THR74LRN = "THR74LRN";

        /// <summary>
        /// THATXA.
        /// </summary>
        public const string THATXA = "THATXA";

        /// <summary>
        /// THSTAM.
        /// </summary>
        public const string THSTAM = "THSTAM";

        /// <summary>
        /// THR74TAP.
        /// </summary>
        public const string THR74TAP = "THR74TAP";

        /// <summary>
        /// THCRCD.
        /// </summary>
        public const string THCRCD = "THCRCD";

        /// <summary>
        /// THCRR.
        /// </summary>
        public const string THCRR = "THCRR";

        /// <summary>
        /// THCTXA.
        /// </summary>
        public const string THCTXA = "THCTXA";

        /// <summary>
        /// THCTAM.
        /// </summary>
        public const string THCTAM = "THCTAM";

        /// <summary>
        /// THR74FTAP.
        /// </summary>
        public const string THR74FTAP = "THR74FTAP";

        /// <summary>
        /// THAN8.
        /// </summary>
        public const string THAN8 = "THAN8";

        /// <summary>
        /// THR74PDJ.
        /// </summary>
        public const string THR74PDJ = "THR74PDJ";

        /// <summary>
        /// THICUT.
        /// </summary>
        public const string THICUT = "THICUT";

        /// <summary>
        /// THICU.
        /// </summary>
        public const string THICU = "THICU";

        /// <summary>
        /// THGLC.
        /// </summary>
        public const string THGLC = "THGLC";

        /// <summary>
        /// THUSER.
        /// </summary>
        public const string THUSER = "THUSER";

        /// <summary>
        /// THPID.
        /// </summary>
        public const string THPID = "THPID";

        /// <summary>
        /// THJOBN.
        /// </summary>
        public const string THJOBN = "THJOBN";

        /// <summary>
        /// THUPMJ.
        /// </summary>
        public const string THUPMJ = "THUPMJ";

        /// <summary>
        /// THUPMT.
        /// </summary>
        public const string THUPMT = "THUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R410";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("THKCO", "THKCO", JdeDataType.String, 10, true, true),
        new JdeField("THDCT", "THDCT", JdeDataType.String, 4, true, true),
        new JdeField("THDOC", "THDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("THTXA1", "THTXA1", JdeDataType.String, 20, true, true),
        new JdeField("THR74LRN", "THR74LRN", JdeDataType.Numeric),
        new JdeField("THATXA", "THATXA", JdeDataType.Numeric),
        new JdeField("THSTAM", "THSTAM", JdeDataType.Numeric),
        new JdeField("THR74TAP", "THR74TAP", JdeDataType.Numeric),
        new JdeField("THCRCD", "THCRCD", JdeDataType.String, 6),
        new JdeField("THCRR", "THCRR", JdeDataType.Numeric),
        new JdeField("THCTXA", "THCTXA", JdeDataType.Numeric),
        new JdeField("THCTAM", "THCTAM", JdeDataType.Numeric),
        new JdeField("THR74FTAP", "THR74FTAP", JdeDataType.Numeric),
        new JdeField("THAN8", "THAN8", JdeDataType.Numeric),
        new JdeField("THR74PDJ", "THR74PDJ", JdeDataType.Numeric),
        new JdeField("THICUT", "THICUT", JdeDataType.String, 4),
        new JdeField("THICU", "THICU", JdeDataType.Numeric),
        new JdeField("THGLC", "THGLC", JdeDataType.String, 8),
        new JdeField("THUSER", "THUSER", JdeDataType.String, 20),
        new JdeField("THPID", "THPID", JdeDataType.String, 20),
        new JdeField("THJOBN", "THJOBN", JdeDataType.String, 20),
        new JdeField("THUPMJ", "THUPMJ", JdeDataType.Numeric),
        new JdeField("THUPMT", "THUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R410_0", "Primary Key on THKCO, THDCT, THDOC, THTXA1", new[] { "THKCO", "THDCT", "THDOC", "THTXA1" }, isUnique: true, isPrimaryKey: true)
    };
}
