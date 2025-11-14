using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E01 - .
/// </summary>
public class F43E01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RHKCOO.
        /// </summary>
        public const string RHKCOO = "RHKCOO";

        /// <summary>
        /// RHDOCO.
        /// </summary>
        public const string RHDOCO = "RHDOCO";

        /// <summary>
        /// RHDCTO.
        /// </summary>
        public const string RHDCTO = "RHDCTO";

        /// <summary>
        /// RHMCU.
        /// </summary>
        public const string RHMCU = "RHMCU";

        /// <summary>
        /// RHTRDJ.
        /// </summary>
        public const string RHTRDJ = "RHTRDJ";

        /// <summary>
        /// RHCRDC.
        /// </summary>
        public const string RHCRDC = "RHCRDC";

        /// <summary>
        /// RHOTOT.
        /// </summary>
        public const string RHOTOT = "RHOTOT";

        /// <summary>
        /// RHNDLN.
        /// </summary>
        public const string RHNDLN = "RHNDLN";

        /// <summary>
        /// RHNCLN.
        /// </summary>
        public const string RHNCLN = "RHNCLN";

        /// <summary>
        /// RHNALN.
        /// </summary>
        public const string RHNALN = "RHNALN";

        /// <summary>
        /// RHERHS.
        /// </summary>
        public const string RHERHS = "RHERHS";

        /// <summary>
        /// RHERTI.
        /// </summary>
        public const string RHERTI = "RHERTI";

        /// <summary>
        /// RHAREQ.
        /// </summary>
        public const string RHAREQ = "RHAREQ";

        /// <summary>
        /// RHTORG.
        /// </summary>
        public const string RHTORG = "RHTORG";

        /// <summary>
        /// RHUSER.
        /// </summary>
        public const string RHUSER = "RHUSER";

        /// <summary>
        /// RHPID.
        /// </summary>
        public const string RHPID = "RHPID";

        /// <summary>
        /// RHJOBN.
        /// </summary>
        public const string RHJOBN = "RHJOBN";

        /// <summary>
        /// RHUPMJ.
        /// </summary>
        public const string RHUPMJ = "RHUPMJ";

        /// <summary>
        /// RHTDAY.
        /// </summary>
        public const string RHTDAY = "RHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43E01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RHKCOO", "RHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RHDOCO", "RHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RHDCTO", "RHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RHMCU", "RHMCU", JdeDataType.String, 24),
        new JdeField("RHTRDJ", "RHTRDJ", JdeDataType.Numeric),
        new JdeField("RHCRDC", "RHCRDC", JdeDataType.String, 6),
        new JdeField("RHOTOT", "RHOTOT", JdeDataType.Numeric),
        new JdeField("RHNDLN", "RHNDLN", JdeDataType.Numeric),
        new JdeField("RHNCLN", "RHNCLN", JdeDataType.Numeric),
        new JdeField("RHNALN", "RHNALN", JdeDataType.Numeric),
        new JdeField("RHERHS", "RHERHS", JdeDataType.String, 24),
        new JdeField("RHERTI", "RHERTI", JdeDataType.String, 60),
        new JdeField("RHAREQ", "RHAREQ", JdeDataType.Numeric),
        new JdeField("RHTORG", "RHTORG", JdeDataType.String, 20),
        new JdeField("RHUSER", "RHUSER", JdeDataType.String, 20),
        new JdeField("RHPID", "RHPID", JdeDataType.String, 20),
        new JdeField("RHJOBN", "RHJOBN", JdeDataType.String, 20),
        new JdeField("RHUPMJ", "RHUPMJ", JdeDataType.Numeric),
        new JdeField("RHTDAY", "RHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E01_0", "Primary Key on RHKCOO, RHDOCO, RHDCTO", new[] { "RHKCOO", "RHDOCO", "RHDCTO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43E01_2", "Index on RHERHS, RHTORG", new[] { "RHERHS", "RHTORG" }),
        new JdeIndex("F43E01_3", "Index on RHERHS, RHAREQ", new[] { "RHERHS", "RHAREQ" })
    };
}
