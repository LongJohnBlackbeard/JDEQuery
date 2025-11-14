using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08750 - .
/// </summary>
public class F08750 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MDANPA.
        /// </summary>
        public const string MDANPA = "MDANPA";

        /// <summary>
        /// MDAN8.
        /// </summary>
        public const string MDAN8 = "MDAN8";

        /// <summary>
        /// MDEFTO.
        /// </summary>
        public const string MDEFTO = "MDEFTO";

        /// <summary>
        /// MDEFTE.
        /// </summary>
        public const string MDEFTE = "MDEFTE";

        /// <summary>
        /// MDUPMJ.
        /// </summary>
        public const string MDUPMJ = "MDUPMJ";

        /// <summary>
        /// MDUPMT.
        /// </summary>
        public const string MDUPMT = "MDUPMT";

        /// <summary>
        /// MDUSER.
        /// </summary>
        public const string MDUSER = "MDUSER";

        /// <summary>
        /// MDPID.
        /// </summary>
        public const string MDPID = "MDPID";

        /// <summary>
        /// MDJOBN.
        /// </summary>
        public const string MDJOBN = "MDJOBN";

        /// <summary>
        /// MDALVL.
        /// </summary>
        public const string MDALVL = "MDALVL";

        /// <summary>
        /// MDDATYP.
        /// </summary>
        public const string MDDATYP = "MDDATYP";
    }

    /// <inheritdoc />
    public override string TableName => "F08750";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MDANPA", "MDANPA", JdeDataType.Numeric, null, true, true),
        new JdeField("MDAN8", "MDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("MDEFTO", "MDEFTO", JdeDataType.Numeric, null, true, true),
        new JdeField("MDEFTE", "MDEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("MDUPMJ", "MDUPMJ", JdeDataType.Numeric),
        new JdeField("MDUPMT", "MDUPMT", JdeDataType.Numeric),
        new JdeField("MDUSER", "MDUSER", JdeDataType.String, 20),
        new JdeField("MDPID", "MDPID", JdeDataType.String, 20),
        new JdeField("MDJOBN", "MDJOBN", JdeDataType.String, 20),
        new JdeField("MDALVL", "MDALVL", JdeDataType.Numeric),
        new JdeField("MDDATYP", "MDDATYP", JdeDataType.String, 16, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08750_0", "Primary Key on MDANPA, MDAN8, MDEFTO, MDEFTE, MDDATYP", new[] { "MDANPA", "MDAN8", "MDEFTO", "MDEFTE", "MDDATYP" }, isUnique: true, isPrimaryKey: true)
    };
}
