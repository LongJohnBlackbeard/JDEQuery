using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D253 - .
/// </summary>
public class F80D253 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CAPRDJ.
        /// </summary>
        public const string CAPRDJ = "CAPRDJ";

        /// <summary>
        /// CAMCU.
        /// </summary>
        public const string CAMCU = "CAMCU";

        /// <summary>
        /// CAAVE.
        /// </summary>
        public const string CAAVE = "CAAVE";

        /// <summary>
        /// CACVE.
        /// </summary>
        public const string CACVE = "CACVE";

        /// <summary>
        /// CAAPE.
        /// </summary>
        public const string CAAPE = "CAAPE";

        /// <summary>
        /// CACCPE.
        /// </summary>
        public const string CACCPE = "CACCPE";

        /// <summary>
        /// CAUSER.
        /// </summary>
        public const string CAUSER = "CAUSER";

        /// <summary>
        /// CAPID.
        /// </summary>
        public const string CAPID = "CAPID";

        /// <summary>
        /// CAMKEY.
        /// </summary>
        public const string CAMKEY = "CAMKEY";

        /// <summary>
        /// CAUTIME.
        /// </summary>
        public const string CAUTIME = "CAUTIME";

        /// <summary>
        /// CAURCD.
        /// </summary>
        public const string CAURCD = "CAURCD";

        /// <summary>
        /// CAURDT.
        /// </summary>
        public const string CAURDT = "CAURDT";

        /// <summary>
        /// CAURAT.
        /// </summary>
        public const string CAURAT = "CAURAT";

        /// <summary>
        /// CAURAB.
        /// </summary>
        public const string CAURAB = "CAURAB";

        /// <summary>
        /// CAURRF.
        /// </summary>
        public const string CAURRF = "CAURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D253";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CAPRDJ", "CAPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CAMCU", "CAMCU", JdeDataType.String, 24, true, true),
        new JdeField("CAAVE", "CAAVE", JdeDataType.Numeric),
        new JdeField("CACVE", "CACVE", JdeDataType.Numeric),
        new JdeField("CAAPE", "CAAPE", JdeDataType.Numeric),
        new JdeField("CACCPE", "CACCPE", JdeDataType.Numeric),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CAMKEY", "CAMKEY", JdeDataType.String, 30),
        new JdeField("CAUTIME", "CAUTIME", JdeDataType.Date),
        new JdeField("CAURCD", "CAURCD", JdeDataType.String, 4),
        new JdeField("CAURDT", "CAURDT", JdeDataType.Numeric),
        new JdeField("CAURAT", "CAURAT", JdeDataType.Numeric),
        new JdeField("CAURAB", "CAURAB", JdeDataType.Numeric),
        new JdeField("CAURRF", "CAURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D253_0", "Primary Key on CAPRDJ, CAMCU", new[] { "CAPRDJ", "CAMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
