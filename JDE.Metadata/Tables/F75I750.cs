using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I750 - .
/// </summary>
public class F75I750 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CEAN8.
        /// </summary>
        public const string CEAN8 = "CEAN8";

        /// <summary>
        /// CEFYR.
        /// </summary>
        public const string CEFYR = "CEFYR";

        /// <summary>
        /// CEMT.
        /// </summary>
        public const string CEMT = "CEMT";

        /// <summary>
        /// CEI75SRCT.
        /// </summary>
        public const string CEI75SRCT = "CEI75SRCT";

        /// <summary>
        /// CEI75TXTY.
        /// </summary>
        public const string CEI75TXTY = "CEI75TXTY";

        /// <summary>
        /// CEBGBL.
        /// </summary>
        public const string CEBGBL = "CEBGBL";

        /// <summary>
        /// CEENBL.
        /// </summary>
        public const string CEENBL = "CEENBL";

        /// <summary>
        /// CEI75DAMT.
        /// </summary>
        public const string CEI75DAMT = "CEI75DAMT";

        /// <summary>
        /// CEI75CAMT.
        /// </summary>
        public const string CEI75CAMT = "CEI75CAMT";

        /// <summary>
        /// CEI75DAID.
        /// </summary>
        public const string CEI75DAID = "CEI75DAID";

        /// <summary>
        /// CEI75CAID.
        /// </summary>
        public const string CEI75CAID = "CEI75CAID";

        /// <summary>
        /// CEI75CAMU.
        /// </summary>
        public const string CEI75CAMU = "CEI75CAMU";

        /// <summary>
        /// CEI75CASG.
        /// </summary>
        public const string CEI75CASG = "CEI75CASG";

        /// <summary>
        /// CEI75NAMT.
        /// </summary>
        public const string CEI75NAMT = "CEI75NAMT";

        /// <summary>
        /// CEI75CHNO.
        /// </summary>
        public const string CEI75CHNO = "CEI75CHNO";

        /// <summary>
        /// CEI75CHDT.
        /// </summary>
        public const string CEI75CHDT = "CEI75CHDT";

        /// <summary>
        /// CEAN8BK.
        /// </summary>
        public const string CEAN8BK = "CEAN8BK";

        /// <summary>
        /// CEUSER.
        /// </summary>
        public const string CEUSER = "CEUSER";

        /// <summary>
        /// CEPID.
        /// </summary>
        public const string CEPID = "CEPID";

        /// <summary>
        /// CEJOBN.
        /// </summary>
        public const string CEJOBN = "CEJOBN";

        /// <summary>
        /// CEUPMJ.
        /// </summary>
        public const string CEUPMJ = "CEUPMJ";

        /// <summary>
        /// CEUPMT.
        /// </summary>
        public const string CEUPMT = "CEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I750";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CEAN8", "CEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CEFYR", "CEFYR", JdeDataType.Numeric, null, true, true),
        new JdeField("CEMT", "CEMT", JdeDataType.Numeric, null, true, true),
        new JdeField("CEI75SRCT", "CEI75SRCT", JdeDataType.String, 12, true, true),
        new JdeField("CEI75TXTY", "CEI75TXTY", JdeDataType.String, 10, true, true),
        new JdeField("CEBGBL", "CEBGBL", JdeDataType.Numeric),
        new JdeField("CEENBL", "CEENBL", JdeDataType.Numeric),
        new JdeField("CEI75DAMT", "CEI75DAMT", JdeDataType.Numeric),
        new JdeField("CEI75CAMT", "CEI75CAMT", JdeDataType.Numeric),
        new JdeField("CEI75DAID", "CEI75DAID", JdeDataType.String, 16),
        new JdeField("CEI75CAID", "CEI75CAID", JdeDataType.String, 16),
        new JdeField("CEI75CAMU", "CEI75CAMU", JdeDataType.Numeric),
        new JdeField("CEI75CASG", "CEI75CASG", JdeDataType.Numeric),
        new JdeField("CEI75NAMT", "CEI75NAMT", JdeDataType.Numeric),
        new JdeField("CEI75CHNO", "CEI75CHNO", JdeDataType.String, 120),
        new JdeField("CEI75CHDT", "CEI75CHDT", JdeDataType.Numeric),
        new JdeField("CEAN8BK", "CEAN8BK", JdeDataType.Numeric),
        new JdeField("CEUSER", "CEUSER", JdeDataType.String, 20),
        new JdeField("CEPID", "CEPID", JdeDataType.String, 20),
        new JdeField("CEJOBN", "CEJOBN", JdeDataType.String, 20),
        new JdeField("CEUPMJ", "CEUPMJ", JdeDataType.Numeric),
        new JdeField("CEUPMT", "CEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I750_0", "Primary Key on CEAN8, CEFYR, CEMT, CEI75SRCT, CEI75TXTY", new[] { "CEAN8", "CEFYR", "CEMT", "CEI75SRCT", "CEI75TXTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I750_2", "Index on CEAN8, CEFYR, CEMT, CEI75TXTY, CEI75SRCT", new[] { "CEAN8", "CEFYR", "CEMT", "CEI75TXTY", "CEI75SRCT" })
    };
}
