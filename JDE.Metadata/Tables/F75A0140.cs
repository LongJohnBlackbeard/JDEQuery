using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0140 - .
/// </summary>
public class F75A0140 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZGAN8.
        /// </summary>
        public const string ZGAN8 = "ZGAN8";

        /// <summary>
        /// ZGHMCO.
        /// </summary>
        public const string ZGHMCO = "ZGHMCO";

        /// <summary>
        /// ZGDTEY.
        /// </summary>
        public const string ZGDTEY = "ZGDTEY";

        /// <summary>
        /// ZGICU.
        /// </summary>
        public const string ZGICU = "ZGICU";

        /// <summary>
        /// ZGLNID.
        /// </summary>
        public const string ZGLNID = "ZGLNID";

        /// <summary>
        /// ZGPGRP.
        /// </summary>
        public const string ZGPGRP = "ZGPGRP";

        /// <summary>
        /// ZGAA02.
        /// </summary>
        public const string ZGAA02 = "ZGAA02";

        /// <summary>
        /// ZGCTRY.
        /// </summary>
        public const string ZGCTRY = "ZGCTRY";

        /// <summary>
        /// ZGBW01.
        /// </summary>
        public const string ZGBW01 = "ZGBW01";

        /// <summary>
        /// ZGBY01.
        /// </summary>
        public const string ZGBY01 = "ZGBY01";

        /// <summary>
        /// ZGDSC.
        /// </summary>
        public const string ZGDSC = "ZGDSC";

        /// <summary>
        /// ZGDCPR.
        /// </summary>
        public const string ZGDCPR = "ZGDCPR";

        /// <summary>
        /// ZGUSER.
        /// </summary>
        public const string ZGUSER = "ZGUSER";

        /// <summary>
        /// ZGUPMJ.
        /// </summary>
        public const string ZGUPMJ = "ZGUPMJ";

        /// <summary>
        /// ZGUPMT.
        /// </summary>
        public const string ZGUPMT = "ZGUPMT";

        /// <summary>
        /// ZGPID.
        /// </summary>
        public const string ZGPID = "ZGPID";

        /// <summary>
        /// ZGJOBN.
        /// </summary>
        public const string ZGJOBN = "ZGJOBN";

        /// <summary>
        /// ZGORAM.
        /// </summary>
        public const string ZGORAM = "ZGORAM";

        /// <summary>
        /// ZGPTAO.
        /// </summary>
        public const string ZGPTAO = "ZGPTAO";

        /// <summary>
        /// ZGSPADAUP1.
        /// </summary>
        public const string ZGSPADAUP1 = "ZGSPADAUP1";

        /// <summary>
        /// ZGSPADAUP2.
        /// </summary>
        public const string ZGSPADAUP2 = "ZGSPADAUP2";

        /// <summary>
        /// ZGSPADAUP3.
        /// </summary>
        public const string ZGSPADAUP3 = "ZGSPADAUP3";

        /// <summary>
        /// ZGSPADAUP4.
        /// </summary>
        public const string ZGSPADAUP4 = "ZGSPADAUP4";

        /// <summary>
        /// ZGSPADFAUP.
        /// </summary>
        public const string ZGSPADFAUP = "ZGSPADFAUP";

        /// <summary>
        /// ZGSPADTAUP.
        /// </summary>
        public const string ZGSPADTAUP = "ZGSPADTAUP";

        /// <summary>
        /// ZGSPAFAUP1.
        /// </summary>
        public const string ZGSPAFAUP1 = "ZGSPAFAUP1";

        /// <summary>
        /// ZGSPAFAUP2.
        /// </summary>
        public const string ZGSPAFAUP2 = "ZGSPAFAUP2";

        /// <summary>
        /// ZGSPAFAUP3.
        /// </summary>
        public const string ZGSPAFAUP3 = "ZGSPAFAUP3";

        /// <summary>
        /// ZGSPAFAUP4.
        /// </summary>
        public const string ZGSPAFAUP4 = "ZGSPAFAUP4";

        /// <summary>
        /// ZGSPANAUP1.
        /// </summary>
        public const string ZGSPANAUP1 = "ZGSPANAUP1";

        /// <summary>
        /// ZGSPANAUP2.
        /// </summary>
        public const string ZGSPANAUP2 = "ZGSPANAUP2";

        /// <summary>
        /// ZGSPANAUP3.
        /// </summary>
        public const string ZGSPANAUP3 = "ZGSPANAUP3";

        /// <summary>
        /// ZGSPANAUP4.
        /// </summary>
        public const string ZGSPANAUP4 = "ZGSPANAUP4";

        /// <summary>
        /// ZGSPASAUP1.
        /// </summary>
        public const string ZGSPASAUP1 = "ZGSPASAUP1";

        /// <summary>
        /// ZGSPASAUP2.
        /// </summary>
        public const string ZGSPASAUP2 = "ZGSPASAUP2";

        /// <summary>
        /// ZGSPASAUP3.
        /// </summary>
        public const string ZGSPASAUP3 = "ZGSPASAUP3";

        /// <summary>
        /// ZGSPASAUP4.
        /// </summary>
        public const string ZGSPASAUP4 = "ZGSPASAUP4";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0140";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZGAN8", "ZGAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ZGHMCO", "ZGHMCO", JdeDataType.String, 10, true, true),
        new JdeField("ZGDTEY", "ZGDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("ZGICU", "ZGICU", JdeDataType.Numeric, null, true, true),
        new JdeField("ZGLNID", "ZGLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZGPGRP", "ZGPGRP", JdeDataType.String, 4),
        new JdeField("ZGAA02", "ZGAA02", JdeDataType.String, 4),
        new JdeField("ZGCTRY", "ZGCTRY", JdeDataType.Numeric),
        new JdeField("ZGBW01", "ZGBW01", JdeDataType.Numeric),
        new JdeField("ZGBY01", "ZGBY01", JdeDataType.Numeric),
        new JdeField("ZGDSC", "ZGDSC", JdeDataType.String, 60),
        new JdeField("ZGDCPR", "ZGDCPR", JdeDataType.String, 2),
        new JdeField("ZGUSER", "ZGUSER", JdeDataType.String, 20),
        new JdeField("ZGUPMJ", "ZGUPMJ", JdeDataType.Numeric),
        new JdeField("ZGUPMT", "ZGUPMT", JdeDataType.Numeric),
        new JdeField("ZGPID", "ZGPID", JdeDataType.String, 20),
        new JdeField("ZGJOBN", "ZGJOBN", JdeDataType.String, 20),
        new JdeField("ZGORAM", "ZGORAM", JdeDataType.String, 2),
        new JdeField("ZGPTAO", "ZGPTAO", JdeDataType.String, 2),
        new JdeField("ZGSPADAUP1", "ZGSPADAUP1", JdeDataType.Numeric),
        new JdeField("ZGSPADAUP2", "ZGSPADAUP2", JdeDataType.Numeric),
        new JdeField("ZGSPADAUP3", "ZGSPADAUP3", JdeDataType.Numeric),
        new JdeField("ZGSPADAUP4", "ZGSPADAUP4", JdeDataType.Numeric),
        new JdeField("ZGSPADFAUP", "ZGSPADFAUP", JdeDataType.Numeric),
        new JdeField("ZGSPADTAUP", "ZGSPADTAUP", JdeDataType.Numeric),
        new JdeField("ZGSPAFAUP1", "ZGSPAFAUP1", JdeDataType.String, 2),
        new JdeField("ZGSPAFAUP2", "ZGSPAFAUP2", JdeDataType.String, 2),
        new JdeField("ZGSPAFAUP3", "ZGSPAFAUP3", JdeDataType.String, 2),
        new JdeField("ZGSPAFAUP4", "ZGSPAFAUP4", JdeDataType.String, 2),
        new JdeField("ZGSPANAUP1", "ZGSPANAUP1", JdeDataType.Numeric),
        new JdeField("ZGSPANAUP2", "ZGSPANAUP2", JdeDataType.Numeric),
        new JdeField("ZGSPANAUP3", "ZGSPANAUP3", JdeDataType.Numeric),
        new JdeField("ZGSPANAUP4", "ZGSPANAUP4", JdeDataType.Numeric),
        new JdeField("ZGSPASAUP1", "ZGSPASAUP1", JdeDataType.String, 60),
        new JdeField("ZGSPASAUP2", "ZGSPASAUP2", JdeDataType.String, 60),
        new JdeField("ZGSPASAUP3", "ZGSPASAUP3", JdeDataType.String, 60),
        new JdeField("ZGSPASAUP4", "ZGSPASAUP4", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0140_0", "Primary Key on ZGDTEY, ZGHMCO, ZGICU, ZGAN8, ZGLNID", new[] { "ZGDTEY", "ZGHMCO", "ZGICU", "ZGAN8", "ZGLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75A0140_2", "Index on ZGDTEY, ZGHMCO, ZGICU, ZGAN8, SYS_NC00038$", new[] { "ZGDTEY", "ZGHMCO", "ZGICU", "ZGAN8", "SYS_NC00038$" })
    };
}
