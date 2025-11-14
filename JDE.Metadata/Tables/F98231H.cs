using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F98231H - .
/// </summary>
public class F98231H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRALPH.
        /// </summary>
        public const string TRALPH = "TRALPH";

        /// <summary>
        /// TRSEQNO.
        /// </summary>
        public const string TRSEQNO = "TRSEQNO";

        /// <summary>
        /// TROMWLOC.
        /// </summary>
        public const string TROMWLOC = "TROMWLOC";

        /// <summary>
        /// TRDL01.
        /// </summary>
        public const string TRDL01 = "TRDL01";

        /// <summary>
        /// TRDL02.
        /// </summary>
        public const string TRDL02 = "TRDL02";

        /// <summary>
        /// TRDL03.
        /// </summary>
        public const string TRDL03 = "TRDL03";

        /// <summary>
        /// TRDL04.
        /// </summary>
        public const string TRDL04 = "TRDL04";

        /// <summary>
        /// TRDL05.
        /// </summary>
        public const string TRDL05 = "TRDL05";

        /// <summary>
        /// TREV01.
        /// </summary>
        public const string TREV01 = "TREV01";

        /// <summary>
        /// TREV02.
        /// </summary>
        public const string TREV02 = "TREV02";

        /// <summary>
        /// TREV03.
        /// </summary>
        public const string TREV03 = "TREV03";

        /// <summary>
        /// TREV04.
        /// </summary>
        public const string TREV04 = "TREV04";

        /// <summary>
        /// TRMATH01.
        /// </summary>
        public const string TRMATH01 = "TRMATH01";

        /// <summary>
        /// TRDATE01.
        /// </summary>
        public const string TRDATE01 = "TRDATE01";

        /// <summary>
        /// TRUSER.
        /// </summary>
        public const string TRUSER = "TRUSER";

        /// <summary>
        /// TRPID.
        /// </summary>
        public const string TRPID = "TRPID";

        /// <summary>
        /// TRUPMJ.
        /// </summary>
        public const string TRUPMJ = "TRUPMJ";

        /// <summary>
        /// TRJOBN.
        /// </summary>
        public const string TRJOBN = "TRJOBN";

        /// <summary>
        /// TRUPMT.
        /// </summary>
        public const string TRUPMT = "TRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F98231H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRALPH", "TRALPH", JdeDataType.String, 80, true, true),
        new JdeField("TRSEQNO", "TRSEQNO", JdeDataType.Numeric, null, true, true),
        new JdeField("TROMWLOC", "TROMWLOC", JdeDataType.String, 60),
        new JdeField("TRDL01", "TRDL01", JdeDataType.String, 60),
        new JdeField("TRDL02", "TRDL02", JdeDataType.String, 60),
        new JdeField("TRDL03", "TRDL03", JdeDataType.String, 60),
        new JdeField("TRDL04", "TRDL04", JdeDataType.String, 60),
        new JdeField("TRDL05", "TRDL05", JdeDataType.String, 60),
        new JdeField("TREV01", "TREV01", JdeDataType.String, 2),
        new JdeField("TREV02", "TREV02", JdeDataType.String, 2),
        new JdeField("TREV03", "TREV03", JdeDataType.String, 2),
        new JdeField("TREV04", "TREV04", JdeDataType.String, 2),
        new JdeField("TRMATH01", "TRMATH01", JdeDataType.Numeric),
        new JdeField("TRDATE01", "TRDATE01", JdeDataType.Numeric),
        new JdeField("TRUSER", "TRUSER", JdeDataType.String, 20),
        new JdeField("TRPID", "TRPID", JdeDataType.String, 20),
        new JdeField("TRUPMJ", "TRUPMJ", JdeDataType.Numeric),
        new JdeField("TRJOBN", "TRJOBN", JdeDataType.String, 20),
        new JdeField("TRUPMT", "TRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F98231H_0", "Primary Key on TRALPH, TRSEQNO", new[] { "TRALPH", "TRSEQNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F98231H_2", "Index on TRALPH", new[] { "TRALPH" })
    };
}
