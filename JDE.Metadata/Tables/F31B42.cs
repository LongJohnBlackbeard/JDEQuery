using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B42 - .
/// </summary>
public class F31B42 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ININSTUID.
        /// </summary>
        public const string ININSTUID = "ININSTUID";

        /// <summary>
        /// ININDATYP.
        /// </summary>
        public const string ININDATYP = "ININDATYP";

        /// <summary>
        /// ININSTDES.
        /// </summary>
        public const string ININSTDES = "ININSTDES";

        /// <summary>
        /// ININBLRUL.
        /// </summary>
        public const string ININBLRUL = "ININBLRUL";

        /// <summary>
        /// ININSTAT.
        /// </summary>
        public const string ININSTAT = "ININSTAT";

        /// <summary>
        /// INSATTHR.
        /// </summary>
        public const string INSATTHR = "INSATTHR";

        /// <summary>
        /// INPID.
        /// </summary>
        public const string INPID = "INPID";

        /// <summary>
        /// INUSER.
        /// </summary>
        public const string INUSER = "INUSER";

        /// <summary>
        /// INJOBN.
        /// </summary>
        public const string INJOBN = "INJOBN";

        /// <summary>
        /// INUPMJ.
        /// </summary>
        public const string INUPMJ = "INUPMJ";

        /// <summary>
        /// INUPMT.
        /// </summary>
        public const string INUPMT = "INUPMT";

        /// <summary>
        /// INURCD.
        /// </summary>
        public const string INURCD = "INURCD";

        /// <summary>
        /// INURDT.
        /// </summary>
        public const string INURDT = "INURDT";

        /// <summary>
        /// INURAT.
        /// </summary>
        public const string INURAT = "INURAT";

        /// <summary>
        /// INURAB.
        /// </summary>
        public const string INURAB = "INURAB";

        /// <summary>
        /// INURRF.
        /// </summary>
        public const string INURRF = "INURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B42";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ININSTUID", "ININSTUID", JdeDataType.Numeric, null, true, true),
        new JdeField("ININDATYP", "ININDATYP", JdeDataType.String, 20),
        new JdeField("ININSTDES", "ININSTDES", JdeDataType.String, 60),
        new JdeField("ININBLRUL", "ININBLRUL", JdeDataType.String, 10),
        new JdeField("ININSTAT", "ININSTAT", JdeDataType.String, 2),
        new JdeField("INSATTHR", "INSATTHR", JdeDataType.Numeric),
        new JdeField("INPID", "INPID", JdeDataType.String, 20),
        new JdeField("INUSER", "INUSER", JdeDataType.String, 20),
        new JdeField("INJOBN", "INJOBN", JdeDataType.String, 20),
        new JdeField("INUPMJ", "INUPMJ", JdeDataType.Numeric),
        new JdeField("INUPMT", "INUPMT", JdeDataType.Numeric),
        new JdeField("INURCD", "INURCD", JdeDataType.String, 4),
        new JdeField("INURDT", "INURDT", JdeDataType.Numeric),
        new JdeField("INURAT", "INURAT", JdeDataType.Numeric),
        new JdeField("INURAB", "INURAB", JdeDataType.Numeric),
        new JdeField("INURRF", "INURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B42_0", "Primary Key on ININSTUID", new[] { "ININSTUID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B42_2", "Index on ININSTAT", new[] { "ININSTAT" })
    };
}
