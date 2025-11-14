using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F150122 - .
/// </summary>
public class F150122 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NYSFDN.
        /// </summary>
        public const string NYSFDN = "NYSFDN";

        /// <summary>
        /// NYDL01.
        /// </summary>
        public const string NYDL01 = "NYDL01";

        /// <summary>
        /// NYSFDM.
        /// </summary>
        public const string NYSFDM = "NYSFDM";

        /// <summary>
        /// NYSFIE.
        /// </summary>
        public const string NYSFIE = "NYSFIE";

        /// <summary>
        /// NYURAB.
        /// </summary>
        public const string NYURAB = "NYURAB";

        /// <summary>
        /// NYURAT.
        /// </summary>
        public const string NYURAT = "NYURAT";

        /// <summary>
        /// NYURCD.
        /// </summary>
        public const string NYURCD = "NYURCD";

        /// <summary>
        /// NYURDT.
        /// </summary>
        public const string NYURDT = "NYURDT";

        /// <summary>
        /// NYURRF.
        /// </summary>
        public const string NYURRF = "NYURRF";

        /// <summary>
        /// NYUPMJ.
        /// </summary>
        public const string NYUPMJ = "NYUPMJ";

        /// <summary>
        /// NYUPMT.
        /// </summary>
        public const string NYUPMT = "NYUPMT";

        /// <summary>
        /// NYUSER.
        /// </summary>
        public const string NYUSER = "NYUSER";

        /// <summary>
        /// NYTORG.
        /// </summary>
        public const string NYTORG = "NYTORG";

        /// <summary>
        /// NYPID.
        /// </summary>
        public const string NYPID = "NYPID";

        /// <summary>
        /// NYENTJ.
        /// </summary>
        public const string NYENTJ = "NYENTJ";

        /// <summary>
        /// NYJOBN.
        /// </summary>
        public const string NYJOBN = "NYJOBN";

        /// <summary>
        /// NYARTY.
        /// </summary>
        public const string NYARTY = "NYARTY";

        /// <summary>
        /// NYCPVA.
        /// </summary>
        public const string NYCPVA = "NYCPVA";

        /// <summary>
        /// NYARDEFID.
        /// </summary>
        public const string NYARDEFID = "NYARDEFID";
    }

    /// <inheritdoc />
    public override string TableName => "F150122";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NYSFDN", "NYSFDN", JdeDataType.String, 20, true, true),
        new JdeField("NYDL01", "NYDL01", JdeDataType.String, 60),
        new JdeField("NYSFDM", "NYSFDM", JdeDataType.String, 2),
        new JdeField("NYSFIE", "NYSFIE", JdeDataType.String, 2),
        new JdeField("NYURAB", "NYURAB", JdeDataType.Numeric),
        new JdeField("NYURAT", "NYURAT", JdeDataType.Numeric),
        new JdeField("NYURCD", "NYURCD", JdeDataType.String, 4),
        new JdeField("NYURDT", "NYURDT", JdeDataType.Numeric),
        new JdeField("NYURRF", "NYURRF", JdeDataType.String, 30),
        new JdeField("NYUPMJ", "NYUPMJ", JdeDataType.Numeric),
        new JdeField("NYUPMT", "NYUPMT", JdeDataType.Numeric),
        new JdeField("NYUSER", "NYUSER", JdeDataType.String, 20),
        new JdeField("NYTORG", "NYTORG", JdeDataType.String, 20),
        new JdeField("NYPID", "NYPID", JdeDataType.String, 20),
        new JdeField("NYENTJ", "NYENTJ", JdeDataType.Numeric),
        new JdeField("NYJOBN", "NYJOBN", JdeDataType.String, 20),
        new JdeField("NYARTY", "NYARTY", JdeDataType.String, 6),
        new JdeField("NYCPVA", "NYCPVA", JdeDataType.Numeric),
        new JdeField("NYARDEFID", "NYARDEFID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F150122_0", "Primary Key on NYSFDN", new[] { "NYSFDN" }, isUnique: true, isPrimaryKey: true)
    };
}
