using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I344C - .
/// </summary>
public class F75I344C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDYEXU.
        /// </summary>
        public const string CDYEXU = "CDYEXU";

        /// <summary>
        /// CDBDSN.
        /// </summary>
        public const string CDBDSN = "CDBDSN";

        /// <summary>
        /// CDEDER.
        /// </summary>
        public const string CDEDER = "CDEDER";

        /// <summary>
        /// CDYARN.
        /// </summary>
        public const string CDYARN = "CDYARN";

        /// <summary>
        /// CDFLAG.
        /// </summary>
        public const string CDFLAG = "CDFLAG";

        /// <summary>
        /// CDDATE1.
        /// </summary>
        public const string CDDATE1 = "CDDATE1";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDJOBN.
        /// </summary>
        public const string CDJOBN = "CDJOBN";

        /// <summary>
        /// CDUPMJ.
        /// </summary>
        public const string CDUPMJ = "CDUPMJ";

        /// <summary>
        /// CDUPMT.
        /// </summary>
        public const string CDUPMT = "CDUPMT";

        /// <summary>
        /// CDS1FU.
        /// </summary>
        public const string CDS1FU = "CDS1FU";

        /// <summary>
        /// CDS2FU.
        /// </summary>
        public const string CDS2FU = "CDS2FU";

        /// <summary>
        /// CDBCFS1.
        /// </summary>
        public const string CDBCFS1 = "CDBCFS1";

        /// <summary>
        /// CDBCFS2.
        /// </summary>
        public const string CDBCFS2 = "CDBCFS2";

        /// <summary>
        /// CDAA.
        /// </summary>
        public const string CDAA = "CDAA";

        /// <summary>
        /// CDAA1.
        /// </summary>
        public const string CDAA1 = "CDAA1";

        /// <summary>
        /// CDAA2.
        /// </summary>
        public const string CDAA2 = "CDAA2";

        /// <summary>
        /// CDAM0.
        /// </summary>
        public const string CDAM0 = "CDAM0";

        /// <summary>
        /// CDAAA.
        /// </summary>
        public const string CDAAA = "CDAAA";

        /// <summary>
        /// CDDATE01.
        /// </summary>
        public const string CDDATE01 = "CDDATE01";

        /// <summary>
        /// CDDATE02.
        /// </summary>
        public const string CDDATE02 = "CDDATE02";

        /// <summary>
        /// CDDATE03.
        /// </summary>
        public const string CDDATE03 = "CDDATE03";

        /// <summary>
        /// CDDATE04.
        /// </summary>
        public const string CDDATE04 = "CDDATE04";

        /// <summary>
        /// CDDATE05.
        /// </summary>
        public const string CDDATE05 = "CDDATE05";

        /// <summary>
        /// CDFUF1.
        /// </summary>
        public const string CDFUF1 = "CDFUF1";

        /// <summary>
        /// CDFUF2.
        /// </summary>
        public const string CDFUF2 = "CDFUF2";

        /// <summary>
        /// CDHT01.
        /// </summary>
        public const string CDHT01 = "CDHT01";

        /// <summary>
        /// CDHT02.
        /// </summary>
        public const string CDHT02 = "CDHT02";

        /// <summary>
        /// CDMATH01.
        /// </summary>
        public const string CDMATH01 = "CDMATH01";

        /// <summary>
        /// CDMATH02.
        /// </summary>
        public const string CDMATH02 = "CDMATH02";

        /// <summary>
        /// CDMATH03.
        /// </summary>
        public const string CDMATH03 = "CDMATH03";

        /// <summary>
        /// CDMATH04.
        /// </summary>
        public const string CDMATH04 = "CDMATH04";

        /// <summary>
        /// CDMATH05.
        /// </summary>
        public const string CDMATH05 = "CDMATH05";
    }

    /// <inheritdoc />
    public override string TableName => "F75I344C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDYEXU", "CDYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("CDBDSN", "CDBDSN", JdeDataType.String, 44, true, true),
        new JdeField("CDEDER", "CDEDER", JdeDataType.String, 2, true, true),
        new JdeField("CDYARN", "CDYARN", JdeDataType.Numeric, null, true, true),
        new JdeField("CDFLAG", "CDFLAG", JdeDataType.String, 2),
        new JdeField("CDDATE1", "CDDATE1", JdeDataType.Numeric),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric),
        new JdeField("CDS1FU", "CDS1FU", JdeDataType.String, 60),
        new JdeField("CDS2FU", "CDS2FU", JdeDataType.String, 60),
        new JdeField("CDBCFS1", "CDBCFS1", JdeDataType.String, 60),
        new JdeField("CDBCFS2", "CDBCFS2", JdeDataType.String, 60),
        new JdeField("CDAA", "CDAA", JdeDataType.Numeric),
        new JdeField("CDAA1", "CDAA1", JdeDataType.Numeric),
        new JdeField("CDAA2", "CDAA2", JdeDataType.Numeric),
        new JdeField("CDAM0", "CDAM0", JdeDataType.Numeric),
        new JdeField("CDAAA", "CDAAA", JdeDataType.Numeric),
        new JdeField("CDDATE01", "CDDATE01", JdeDataType.Numeric),
        new JdeField("CDDATE02", "CDDATE02", JdeDataType.Numeric),
        new JdeField("CDDATE03", "CDDATE03", JdeDataType.Numeric),
        new JdeField("CDDATE04", "CDDATE04", JdeDataType.Numeric),
        new JdeField("CDDATE05", "CDDATE05", JdeDataType.Numeric),
        new JdeField("CDFUF1", "CDFUF1", JdeDataType.String, 2),
        new JdeField("CDFUF2", "CDFUF2", JdeDataType.String, 2),
        new JdeField("CDHT01", "CDHT01", JdeDataType.String, 2),
        new JdeField("CDHT02", "CDHT02", JdeDataType.String, 2),
        new JdeField("CDMATH01", "CDMATH01", JdeDataType.Numeric),
        new JdeField("CDMATH02", "CDMATH02", JdeDataType.Numeric),
        new JdeField("CDMATH03", "CDMATH03", JdeDataType.Numeric),
        new JdeField("CDMATH04", "CDMATH04", JdeDataType.Numeric),
        new JdeField("CDMATH05", "CDMATH05", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I344C_0", "Primary Key on CDYEXU, CDBDSN, CDEDER, CDYARN", new[] { "CDYEXU", "CDBDSN", "CDEDER", "CDYARN" }, isUnique: true, isPrimaryKey: true)
    };
}
