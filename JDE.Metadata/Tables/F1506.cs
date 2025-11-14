using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1506 - .
/// </summary>
public class F1506 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OPMCUS.
        /// </summary>
        public const string OPMCUS = "OPMCUS";

        /// <summary>
        /// OPMCU.
        /// </summary>
        public const string OPMCU = "OPMCU";

        /// <summary>
        /// OPFLOR.
        /// </summary>
        public const string OPFLOR = "OPFLOR";

        /// <summary>
        /// OPFOTY.
        /// </summary>
        public const string OPFOTY = "OPFOTY";

        /// <summary>
        /// OPDL01.
        /// </summary>
        public const string OPDL01 = "OPDL01";

        /// <summary>
        /// OPRL01.
        /// </summary>
        public const string OPRL01 = "OPRL01";

        /// <summary>
        /// OPRL02.
        /// </summary>
        public const string OPRL02 = "OPRL02";

        /// <summary>
        /// OPRL03.
        /// </summary>
        public const string OPRL03 = "OPRL03";

        /// <summary>
        /// OPRL04.
        /// </summary>
        public const string OPRL04 = "OPRL04";

        /// <summary>
        /// OPRL05.
        /// </summary>
        public const string OPRL05 = "OPRL05";

        /// <summary>
        /// OPUSER.
        /// </summary>
        public const string OPUSER = "OPUSER";

        /// <summary>
        /// OPUPMJ.
        /// </summary>
        public const string OPUPMJ = "OPUPMJ";

        /// <summary>
        /// OPPID.
        /// </summary>
        public const string OPPID = "OPPID";

        /// <summary>
        /// OPJOBN.
        /// </summary>
        public const string OPJOBN = "OPJOBN";

        /// <summary>
        /// OPCO.
        /// </summary>
        public const string OPCO = "OPCO";

        /// <summary>
        /// OPARGC.
        /// </summary>
        public const string OPARGC = "OPARGC";

        /// <summary>
        /// OPARGV.
        /// </summary>
        public const string OPARGV = "OPARGV";

        /// <summary>
        /// OPUPMT.
        /// </summary>
        public const string OPUPMT = "OPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1506";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OPMCUS", "OPMCUS", JdeDataType.String, 24),
        new JdeField("OPMCU", "OPMCU", JdeDataType.String, 24, true, true),
        new JdeField("OPFLOR", "OPFLOR", JdeDataType.String, 8, true, true),
        new JdeField("OPFOTY", "OPFOTY", JdeDataType.String, 10),
        new JdeField("OPDL01", "OPDL01", JdeDataType.String, 60),
        new JdeField("OPRL01", "OPRL01", JdeDataType.String, 6),
        new JdeField("OPRL02", "OPRL02", JdeDataType.String, 6),
        new JdeField("OPRL03", "OPRL03", JdeDataType.String, 6),
        new JdeField("OPRL04", "OPRL04", JdeDataType.String, 6),
        new JdeField("OPRL05", "OPRL05", JdeDataType.String, 6),
        new JdeField("OPUSER", "OPUSER", JdeDataType.String, 20),
        new JdeField("OPUPMJ", "OPUPMJ", JdeDataType.Numeric),
        new JdeField("OPPID", "OPPID", JdeDataType.String, 20),
        new JdeField("OPJOBN", "OPJOBN", JdeDataType.String, 20),
        new JdeField("OPCO", "OPCO", JdeDataType.String, 10),
        new JdeField("OPARGC", "OPARGC", JdeDataType.String, 8, true, true),
        new JdeField("OPARGV", "OPARGV", JdeDataType.String, 10, true, true),
        new JdeField("OPUPMT", "OPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1506_0", "Primary Key on OPMCU, OPFLOR, OPARGC, OPARGV", new[] { "OPMCU", "OPFLOR", "OPARGC", "OPARGV" }, isUnique: true, isPrimaryKey: true)
    };
}
