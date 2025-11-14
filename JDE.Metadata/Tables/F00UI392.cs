using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00UI392 - .
/// </summary>
public class F00UI392 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GWJOBS.
        /// </summary>
        public const string GWJOBS = "GWJOBS";

        /// <summary>
        /// GWCTID.
        /// </summary>
        public const string GWCTID = "GWCTID";

        /// <summary>
        /// GWEXFD.
        /// </summary>
        public const string GWEXFD = "GWEXFD";

        /// <summary>
        /// GWTBNM.
        /// </summary>
        public const string GWTBNM = "GWTBNM";

        /// <summary>
        /// GWSBVL.
        /// </summary>
        public const string GWSBVL = "GWSBVL";

        /// <summary>
        /// GWURAB.
        /// </summary>
        public const string GWURAB = "GWURAB";

        /// <summary>
        /// GWURAT.
        /// </summary>
        public const string GWURAT = "GWURAT";

        /// <summary>
        /// GWURCD.
        /// </summary>
        public const string GWURCD = "GWURCD";

        /// <summary>
        /// GWURDT.
        /// </summary>
        public const string GWURDT = "GWURDT";

        /// <summary>
        /// GWURRF.
        /// </summary>
        public const string GWURRF = "GWURRF";

        /// <summary>
        /// GWUSER.
        /// </summary>
        public const string GWUSER = "GWUSER";

        /// <summary>
        /// GWPID.
        /// </summary>
        public const string GWPID = "GWPID";

        /// <summary>
        /// GWJOBN.
        /// </summary>
        public const string GWJOBN = "GWJOBN";

        /// <summary>
        /// GWUPMJ.
        /// </summary>
        public const string GWUPMJ = "GWUPMJ";

        /// <summary>
        /// GWUPMT.
        /// </summary>
        public const string GWUPMT = "GWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F00UI392";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GWJOBS", "GWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("GWCTID", "GWCTID", JdeDataType.String, 30, true, true),
        new JdeField("GWEXFD", "GWEXFD", JdeDataType.String, 160, true, true),
        new JdeField("GWTBNM", "GWTBNM", JdeDataType.String, 60, true, true),
        new JdeField("GWSBVL", "GWSBVL", JdeDataType.String, 160),
        new JdeField("GWURAB", "GWURAB", JdeDataType.Numeric),
        new JdeField("GWURAT", "GWURAT", JdeDataType.Numeric),
        new JdeField("GWURCD", "GWURCD", JdeDataType.String, 4),
        new JdeField("GWURDT", "GWURDT", JdeDataType.Numeric),
        new JdeField("GWURRF", "GWURRF", JdeDataType.String, 30),
        new JdeField("GWUSER", "GWUSER", JdeDataType.String, 20),
        new JdeField("GWPID", "GWPID", JdeDataType.String, 20),
        new JdeField("GWJOBN", "GWJOBN", JdeDataType.String, 20),
        new JdeField("GWUPMJ", "GWUPMJ", JdeDataType.Numeric),
        new JdeField("GWUPMT", "GWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00UI392_0", "Primary Key on GWJOBS, GWCTID, GWEXFD, GWTBNM", new[] { "GWJOBS", "GWCTID", "GWEXFD", "GWTBNM" }, isUnique: true, isPrimaryKey: true)
    };
}
