using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0811629 - .
/// </summary>
public class F0811629 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APACAD.
        /// </summary>
        public const string APACAD = "APACAD";

        /// <summary>
        /// APACA#.
        /// </summary>
        public const string APACA_ = "APACA#";

        /// <summary>
        /// APVERS.
        /// </summary>
        public const string APVERS = "APVERS";

        /// <summary>
        /// APALE.
        /// </summary>
        public const string APALE = "APALE";

        /// <summary>
        /// APACAM.
        /// </summary>
        public const string APACAM = "APACAM";

        /// <summary>
        /// APLBSD.
        /// </summary>
        public const string APLBSD = "APLBSD";

        /// <summary>
        /// APLBED.
        /// </summary>
        public const string APLBED = "APLBED";

        /// <summary>
        /// APADMS.
        /// </summary>
        public const string APADMS = "APADMS";

        /// <summary>
        /// APADME.
        /// </summary>
        public const string APADME = "APADME";

        /// <summary>
        /// APSPSD.
        /// </summary>
        public const string APSPSD = "APSPSD";

        /// <summary>
        /// APSPED.
        /// </summary>
        public const string APSPED = "APSPED";

        /// <summary>
        /// APACWK.
        /// </summary>
        public const string APACWK = "APACWK";

        /// <summary>
        /// APACMO.
        /// </summary>
        public const string APACMO = "APACMO";

        /// <summary>
        /// APDLS.
        /// </summary>
        public const string APDLS = "APDLS";

        /// <summary>
        /// APTLS.
        /// </summary>
        public const string APTLS = "APTLS";

        /// <summary>
        /// APACES.
        /// </summary>
        public const string APACES = "APACES";

        /// <summary>
        /// APESEDF.
        /// </summary>
        public const string APESEDF = "APESEDF";

        /// <summary>
        /// APSPADUSC1.
        /// </summary>
        public const string APSPADUSC1 = "APSPADUSC1";

        /// <summary>
        /// APSPADUSC2.
        /// </summary>
        public const string APSPADUSC2 = "APSPADUSC2";

        /// <summary>
        /// APSPASUSC1.
        /// </summary>
        public const string APSPASUSC1 = "APSPASUSC1";

        /// <summary>
        /// APSPASUSC2.
        /// </summary>
        public const string APSPASUSC2 = "APSPASUSC2";

        /// <summary>
        /// APSPANUSC1.
        /// </summary>
        public const string APSPANUSC1 = "APSPANUSC1";

        /// <summary>
        /// APSPANUSC2.
        /// </summary>
        public const string APSPANUSC2 = "APSPANUSC2";

        /// <summary>
        /// APSPACUSC1.
        /// </summary>
        public const string APSPACUSC1 = "APSPACUSC1";

        /// <summary>
        /// APSPACUSC2.
        /// </summary>
        public const string APSPACUSC2 = "APSPACUSC2";

        /// <summary>
        /// APUSER.
        /// </summary>
        public const string APUSER = "APUSER";

        /// <summary>
        /// APPID.
        /// </summary>
        public const string APPID = "APPID";

        /// <summary>
        /// APJOBN.
        /// </summary>
        public const string APJOBN = "APJOBN";

        /// <summary>
        /// APUPMJ.
        /// </summary>
        public const string APUPMJ = "APUPMJ";

        /// <summary>
        /// APUPMT.
        /// </summary>
        public const string APUPMT = "APUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0811629";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APACAD", "APACAD", JdeDataType.String, 20, true, true),
        new JdeField("APACA#", "APACA#", JdeDataType.Numeric, null, true, true),
        new JdeField("APVERS", "APVERS", JdeDataType.String, 20),
        new JdeField("APALE", "APALE", JdeDataType.String, 20),
        new JdeField("APACAM", "APACAM", JdeDataType.String, 2),
        new JdeField("APLBSD", "APLBSD", JdeDataType.Numeric),
        new JdeField("APLBED", "APLBED", JdeDataType.Numeric),
        new JdeField("APADMS", "APADMS", JdeDataType.Numeric),
        new JdeField("APADME", "APADME", JdeDataType.Numeric),
        new JdeField("APSPSD", "APSPSD", JdeDataType.Numeric),
        new JdeField("APSPED", "APSPED", JdeDataType.Numeric),
        new JdeField("APACWK", "APACWK", JdeDataType.Numeric),
        new JdeField("APACMO", "APACMO", JdeDataType.Numeric),
        new JdeField("APDLS", "APDLS", JdeDataType.Numeric),
        new JdeField("APTLS", "APTLS", JdeDataType.Numeric),
        new JdeField("APACES", "APACES", JdeDataType.String, 4),
        new JdeField("APESEDF", "APESEDF", JdeDataType.Numeric),
        new JdeField("APSPADUSC1", "APSPADUSC1", JdeDataType.Numeric),
        new JdeField("APSPADUSC2", "APSPADUSC2", JdeDataType.Numeric),
        new JdeField("APSPASUSC1", "APSPASUSC1", JdeDataType.String, 60),
        new JdeField("APSPASUSC2", "APSPASUSC2", JdeDataType.String, 60),
        new JdeField("APSPANUSC1", "APSPANUSC1", JdeDataType.Numeric),
        new JdeField("APSPANUSC2", "APSPANUSC2", JdeDataType.Numeric),
        new JdeField("APSPACUSC1", "APSPACUSC1", JdeDataType.String, 2),
        new JdeField("APSPACUSC2", "APSPACUSC2", JdeDataType.String, 2),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20),
        new JdeField("APPID", "APPID", JdeDataType.String, 20),
        new JdeField("APJOBN", "APJOBN", JdeDataType.String, 20),
        new JdeField("APUPMJ", "APUPMJ", JdeDataType.Numeric),
        new JdeField("APUPMT", "APUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0811629_0", "Primary Key on APACAD, APACA#", new[] { "APACAD", "APACA#" }, isUnique: true, isPrimaryKey: true)
    };
}
