using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42420TX - .
/// </summary>
public class F42420TX : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TAKCOO.
        /// </summary>
        public const string TAKCOO = "TAKCOO";

        /// <summary>
        /// TADOCO.
        /// </summary>
        public const string TADOCO = "TADOCO";

        /// <summary>
        /// TADCTO.
        /// </summary>
        public const string TADCTO = "TADCTO";

        /// <summary>
        /// TALNID.
        /// </summary>
        public const string TALNID = "TALNID";

        /// <summary>
        /// TACORD.
        /// </summary>
        public const string TACORD = "TACORD";

        /// <summary>
        /// TAUPMJ.
        /// </summary>
        public const string TAUPMJ = "TAUPMJ";

        /// <summary>
        /// TATDAY.
        /// </summary>
        public const string TATDAY = "TATDAY";

        /// <summary>
        /// TAUSER.
        /// </summary>
        public const string TAUSER = "TAUSER";

        /// <summary>
        /// TACRCD.
        /// </summary>
        public const string TACRCD = "TACRCD";

        /// <summary>
        /// TATUPRC.
        /// </summary>
        public const string TATUPRC = "TATUPRC";

        /// <summary>
        /// TATAEXP.
        /// </summary>
        public const string TATAEXP = "TATAEXP";

        /// <summary>
        /// TAUTA.
        /// </summary>
        public const string TAUTA = "TAUTA";

        /// <summary>
        /// TAETA.
        /// </summary>
        public const string TAETA = "TAETA";

        /// <summary>
        /// TATFUP.
        /// </summary>
        public const string TATFUP = "TATFUP";

        /// <summary>
        /// TATFEA.
        /// </summary>
        public const string TATFEA = "TATFEA";

        /// <summary>
        /// TAFUTA.
        /// </summary>
        public const string TAFUTA = "TAFUTA";

        /// <summary>
        /// TAFETA.
        /// </summary>
        public const string TAFETA = "TAFETA";
    }

    /// <inheritdoc />
    public override string TableName => "F42420TX";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TAKCOO", "TAKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TADOCO", "TADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TADCTO", "TADCTO", JdeDataType.String, 4, true, true),
        new JdeField("TALNID", "TALNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TACORD", "TACORD", JdeDataType.Numeric, null, true, true),
        new JdeField("TAUPMJ", "TAUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TATDAY", "TATDAY", JdeDataType.Numeric, null, true, true),
        new JdeField("TAUSER", "TAUSER", JdeDataType.String, 20, true, true),
        new JdeField("TACRCD", "TACRCD", JdeDataType.String, 6),
        new JdeField("TATUPRC", "TATUPRC", JdeDataType.Numeric),
        new JdeField("TATAEXP", "TATAEXP", JdeDataType.Numeric),
        new JdeField("TAUTA", "TAUTA", JdeDataType.Numeric),
        new JdeField("TAETA", "TAETA", JdeDataType.Numeric),
        new JdeField("TATFUP", "TATFUP", JdeDataType.Numeric),
        new JdeField("TATFEA", "TATFEA", JdeDataType.Numeric),
        new JdeField("TAFUTA", "TAFUTA", JdeDataType.Numeric),
        new JdeField("TAFETA", "TAFETA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42420TX_0", "Primary Key on TAKCOO, TADOCO, TADCTO, TALNID, TACORD, TAUPMJ, TATDAY, TAUSER", new[] { "TAKCOO", "TADOCO", "TADCTO", "TALNID", "TACORD", "TAUPMJ", "TATDAY", "TAUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
