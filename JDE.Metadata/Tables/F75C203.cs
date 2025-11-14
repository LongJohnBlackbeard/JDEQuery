using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C203 - .
/// </summary>
public class F75C203 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FANUMB.
        /// </summary>
        public const string FANUMB = "FANUMB";

        /// <summary>
        /// FAMCU.
        /// </summary>
        public const string FAMCU = "FAMCU";

        /// <summary>
        /// FAC75ACCYR.
        /// </summary>
        public const string FAC75ACCYR = "FAC75ACCYR";

        /// <summary>
        /// FAC75ACCPD.
        /// </summary>
        public const string FAC75ACCPD = "FAC75ACCPD";

        /// <summary>
        /// FAC75DEPRT.
        /// </summary>
        public const string FAC75DEPRT = "FAC75DEPRT";

        /// <summary>
        /// FAFUTMATH1.
        /// </summary>
        public const string FAFUTMATH1 = "FAFUTMATH1";

        /// <summary>
        /// FAFUTSTR1.
        /// </summary>
        public const string FAFUTSTR1 = "FAFUTSTR1";

        /// <summary>
        /// FAFUTSTR2.
        /// </summary>
        public const string FAFUTSTR2 = "FAFUTSTR2";

        /// <summary>
        /// FAFUTDATE1.
        /// </summary>
        public const string FAFUTDATE1 = "FAFUTDATE1";

        /// <summary>
        /// FAFUTUO1.
        /// </summary>
        public const string FAFUTUO1 = "FAFUTUO1";

        /// <summary>
        /// FAUSER.
        /// </summary>
        public const string FAUSER = "FAUSER";

        /// <summary>
        /// FAPID.
        /// </summary>
        public const string FAPID = "FAPID";

        /// <summary>
        /// FAJOBN.
        /// </summary>
        public const string FAJOBN = "FAJOBN";

        /// <summary>
        /// FAUPMJ.
        /// </summary>
        public const string FAUPMJ = "FAUPMJ";

        /// <summary>
        /// FAUPMT.
        /// </summary>
        public const string FAUPMT = "FAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C203";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FANUMB", "FANUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("FAMCU", "FAMCU", JdeDataType.String, 24, true, true),
        new JdeField("FAC75ACCYR", "FAC75ACCYR", JdeDataType.Numeric, null, true, true),
        new JdeField("FAC75ACCPD", "FAC75ACCPD", JdeDataType.Numeric, null, true, true),
        new JdeField("FAC75DEPRT", "FAC75DEPRT", JdeDataType.Numeric),
        new JdeField("FAFUTMATH1", "FAFUTMATH1", JdeDataType.Numeric),
        new JdeField("FAFUTSTR1", "FAFUTSTR1", JdeDataType.String, 100),
        new JdeField("FAFUTSTR2", "FAFUTSTR2", JdeDataType.String, 100),
        new JdeField("FAFUTDATE1", "FAFUTDATE1", JdeDataType.Numeric),
        new JdeField("FAFUTUO1", "FAFUTUO1", JdeDataType.String, 2),
        new JdeField("FAUSER", "FAUSER", JdeDataType.String, 20),
        new JdeField("FAPID", "FAPID", JdeDataType.String, 20),
        new JdeField("FAJOBN", "FAJOBN", JdeDataType.String, 20),
        new JdeField("FAUPMJ", "FAUPMJ", JdeDataType.Numeric),
        new JdeField("FAUPMT", "FAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C203_0", "Primary Key on FANUMB, FAMCU, FAC75ACCYR, FAC75ACCPD", new[] { "FANUMB", "FAMCU", "FAC75ACCYR", "FAC75ACCPD" }, isUnique: true, isPrimaryKey: true)
    };
}
