using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41512T - .
/// </summary>
public class F41512T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PGGLRN.
        /// </summary>
        public const string PGGLRN = "PGGLRN";

        /// <summary>
        /// PGLOTN.
        /// </summary>
        public const string PGLOTN = "PGLOTN";

        /// <summary>
        /// PGUSER.
        /// </summary>
        public const string PGUSER = "PGUSER";

        /// <summary>
        /// PGPID.
        /// </summary>
        public const string PGPID = "PGPID";

        /// <summary>
        /// PGJOBN.
        /// </summary>
        public const string PGJOBN = "PGJOBN";

        /// <summary>
        /// PGUPMJ.
        /// </summary>
        public const string PGUPMJ = "PGUPMJ";

        /// <summary>
        /// PGTDAY.
        /// </summary>
        public const string PGTDAY = "PGTDAY";

        /// <summary>
        /// PGFUTCHAR1.
        /// </summary>
        public const string PGFUTCHAR1 = "PGFUTCHAR1";

        /// <summary>
        /// PGFUTCHAR2.
        /// </summary>
        public const string PGFUTCHAR2 = "PGFUTCHAR2";

        /// <summary>
        /// PGFUTCHAR3.
        /// </summary>
        public const string PGFUTCHAR3 = "PGFUTCHAR3";

        /// <summary>
        /// PGFUTSTR1.
        /// </summary>
        public const string PGFUTSTR1 = "PGFUTSTR1";

        /// <summary>
        /// PGFUTSTR2.
        /// </summary>
        public const string PGFUTSTR2 = "PGFUTSTR2";

        /// <summary>
        /// PGFUSTR3.
        /// </summary>
        public const string PGFUSTR3 = "PGFUSTR3";

        /// <summary>
        /// PGFUNUM1.
        /// </summary>
        public const string PGFUNUM1 = "PGFUNUM1";

        /// <summary>
        /// PGFUNUM2.
        /// </summary>
        public const string PGFUNUM2 = "PGFUNUM2";

        /// <summary>
        /// PGFUNUM3.
        /// </summary>
        public const string PGFUNUM3 = "PGFUNUM3";

        /// <summary>
        /// PGFUDT1.
        /// </summary>
        public const string PGFUDT1 = "PGFUDT1";
    }

    /// <inheritdoc />
    public override string TableName => "F41512T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PGGLRN", "PGGLRN", JdeDataType.Numeric, null, true, true),
        new JdeField("PGLOTN", "PGLOTN", JdeDataType.String, 60),
        new JdeField("PGUSER", "PGUSER", JdeDataType.String, 20),
        new JdeField("PGPID", "PGPID", JdeDataType.String, 20),
        new JdeField("PGJOBN", "PGJOBN", JdeDataType.String, 20),
        new JdeField("PGUPMJ", "PGUPMJ", JdeDataType.Numeric),
        new JdeField("PGTDAY", "PGTDAY", JdeDataType.Numeric),
        new JdeField("PGFUTCHAR1", "PGFUTCHAR1", JdeDataType.String, 2),
        new JdeField("PGFUTCHAR2", "PGFUTCHAR2", JdeDataType.String, 2),
        new JdeField("PGFUTCHAR3", "PGFUTCHAR3", JdeDataType.String, 2),
        new JdeField("PGFUTSTR1", "PGFUTSTR1", JdeDataType.String, 100),
        new JdeField("PGFUTSTR2", "PGFUTSTR2", JdeDataType.String, 100),
        new JdeField("PGFUSTR3", "PGFUSTR3", JdeDataType.String, 100),
        new JdeField("PGFUNUM1", "PGFUNUM1", JdeDataType.Numeric),
        new JdeField("PGFUNUM2", "PGFUNUM2", JdeDataType.Numeric),
        new JdeField("PGFUNUM3", "PGFUNUM3", JdeDataType.Numeric),
        new JdeField("PGFUDT1", "PGFUDT1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41512T_0", "Primary Key on PGGLRN", new[] { "PGGLRN" }, isUnique: true, isPrimaryKey: true)
    };
}
