using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0208 - .
/// </summary>
public class F74U0208 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PB74UBLPTN.
        /// </summary>
        public const string PB74UBLPTN = "PB74UBLPTN";

        /// <summary>
        /// PBBLFR.
        /// </summary>
        public const string PBBLFR = "PBBLFR";

        /// <summary>
        /// PB74USTA.
        /// </summary>
        public const string PB74USTA = "PB74USTA";

        /// <summary>
        /// PBREM1.
        /// </summary>
        public const string PBREM1 = "PBREM1";

        /// <summary>
        /// PBURCD.
        /// </summary>
        public const string PBURCD = "PBURCD";

        /// <summary>
        /// PBURDT.
        /// </summary>
        public const string PBURDT = "PBURDT";

        /// <summary>
        /// PBURAT.
        /// </summary>
        public const string PBURAT = "PBURAT";

        /// <summary>
        /// PBURAB.
        /// </summary>
        public const string PBURAB = "PBURAB";

        /// <summary>
        /// PBURRF.
        /// </summary>
        public const string PBURRF = "PBURRF";

        /// <summary>
        /// PBUSER.
        /// </summary>
        public const string PBUSER = "PBUSER";

        /// <summary>
        /// PBPID.
        /// </summary>
        public const string PBPID = "PBPID";

        /// <summary>
        /// PBUPMJ.
        /// </summary>
        public const string PBUPMJ = "PBUPMJ";

        /// <summary>
        /// PBUPMT.
        /// </summary>
        public const string PBUPMT = "PBUPMT";

        /// <summary>
        /// PBJOBN.
        /// </summary>
        public const string PBJOBN = "PBJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0208";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PB74UBLPTN", "PB74UBLPTN", JdeDataType.String, 10, true, true),
        new JdeField("PBBLFR", "PBBLFR", JdeDataType.String, 2, true, true),
        new JdeField("PB74USTA", "PB74USTA", JdeDataType.String, 2),
        new JdeField("PBREM1", "PBREM1", JdeDataType.String, 80),
        new JdeField("PBURCD", "PBURCD", JdeDataType.String, 4),
        new JdeField("PBURDT", "PBURDT", JdeDataType.Numeric),
        new JdeField("PBURAT", "PBURAT", JdeDataType.Numeric),
        new JdeField("PBURAB", "PBURAB", JdeDataType.Numeric),
        new JdeField("PBURRF", "PBURRF", JdeDataType.String, 30),
        new JdeField("PBUSER", "PBUSER", JdeDataType.String, 20),
        new JdeField("PBPID", "PBPID", JdeDataType.String, 20),
        new JdeField("PBUPMJ", "PBUPMJ", JdeDataType.Numeric),
        new JdeField("PBUPMT", "PBUPMT", JdeDataType.Numeric),
        new JdeField("PBJOBN", "PBJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0208_0", "Primary Key on PB74UBLPTN, PBBLFR", new[] { "PB74UBLPTN", "PBBLFR" }, isUnique: true, isPrimaryKey: true)
    };
}
