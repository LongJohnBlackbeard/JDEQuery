using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C001 - .
/// </summary>
public class F76C001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PGEF11.
        /// </summary>
        public const string PGEF11 = "PGEF11";

        /// <summary>
        /// PGMCU.
        /// </summary>
        public const string PGMCU = "PGMCU";

        /// <summary>
        /// PGINT01.
        /// </summary>
        public const string PGINT01 = "PGINT01";

        /// <summary>
        /// PGINT02.
        /// </summary>
        public const string PGINT02 = "PGINT02";

        /// <summary>
        /// PGINT03.
        /// </summary>
        public const string PGINT03 = "PGINT03";

        /// <summary>
        /// PGINT04.
        /// </summary>
        public const string PGINT04 = "PGINT04";

        /// <summary>
        /// PGINT05.
        /// </summary>
        public const string PGINT05 = "PGINT05";

        /// <summary>
        /// PGRT.
        /// </summary>
        public const string PGRT = "PGRT";

        /// <summary>
        /// PGAN8.
        /// </summary>
        public const string PGAN8 = "PGAN8";

        /// <summary>
        /// PGOSTP.
        /// </summary>
        public const string PGOSTP = "PGOSTP";

        /// <summary>
        /// PGEF01.
        /// </summary>
        public const string PGEF01 = "PGEF01";

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
        /// PGUPMT.
        /// </summary>
        public const string PGUPMT = "PGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76C001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PGEF11", "PGEF11", JdeDataType.Numeric, null, true, true),
        new JdeField("PGMCU", "PGMCU", JdeDataType.String, 24),
        new JdeField("PGINT01", "PGINT01", JdeDataType.Numeric),
        new JdeField("PGINT02", "PGINT02", JdeDataType.Numeric),
        new JdeField("PGINT03", "PGINT03", JdeDataType.Numeric),
        new JdeField("PGINT04", "PGINT04", JdeDataType.Numeric),
        new JdeField("PGINT05", "PGINT05", JdeDataType.Numeric),
        new JdeField("PGRT", "PGRT", JdeDataType.String, 4),
        new JdeField("PGAN8", "PGAN8", JdeDataType.Numeric),
        new JdeField("PGOSTP", "PGOSTP", JdeDataType.String, 6),
        new JdeField("PGEF01", "PGEF01", JdeDataType.Numeric),
        new JdeField("PGUSER", "PGUSER", JdeDataType.String, 20),
        new JdeField("PGPID", "PGPID", JdeDataType.String, 20),
        new JdeField("PGJOBN", "PGJOBN", JdeDataType.String, 20),
        new JdeField("PGUPMJ", "PGUPMJ", JdeDataType.Numeric),
        new JdeField("PGUPMT", "PGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C001_0", "Primary Key on PGEF11", new[] { "PGEF11" }, isUnique: true, isPrimaryKey: true)
    };
}
