using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F12003 - .
/// </summary>
public class F12003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FFCO.
        /// </summary>
        public const string FFCO = "FFCO";

        /// <summary>
        /// FFDAOB.
        /// </summary>
        public const string FFDAOB = "FFDAOB";

        /// <summary>
        /// FFDASB.
        /// </summary>
        public const string FFDASB = "FFDASB";

        /// <summary>
        /// FFLT.
        /// </summary>
        public const string FFLT = "FFLT";

        /// <summary>
        /// FFADM.
        /// </summary>
        public const string FFADM = "FFADM";

        /// <summary>
        /// FFADLM.
        /// </summary>
        public const string FFADLM = "FFADLM";

        /// <summary>
        /// FFITAC.
        /// </summary>
        public const string FFITAC = "FFITAC";

        /// <summary>
        /// FFADMP.
        /// </summary>
        public const string FFADMP = "FFADMP";

        /// <summary>
        /// FFADSN.
        /// </summary>
        public const string FFADSN = "FFADSN";

        /// <summary>
        /// FFDIR1.
        /// </summary>
        public const string FFDIR1 = "FFDIR1";

        /// <summary>
        /// FFLCT.
        /// </summary>
        public const string FFLCT = "FFLCT";

        /// <summary>
        /// FFUSER.
        /// </summary>
        public const string FFUSER = "FFUSER";

        /// <summary>
        /// FFPID.
        /// </summary>
        public const string FFPID = "FFPID";

        /// <summary>
        /// FFUPMJ.
        /// </summary>
        public const string FFUPMJ = "FFUPMJ";

        /// <summary>
        /// FFJOBN.
        /// </summary>
        public const string FFJOBN = "FFJOBN";

        /// <summary>
        /// FFUPMT.
        /// </summary>
        public const string FFUPMT = "FFUPMT";

        /// <summary>
        /// FFACL1.
        /// </summary>
        public const string FFACL1 = "FFACL1";

        /// <summary>
        /// FFADC.
        /// </summary>
        public const string FFADC = "FFADC";

        /// <summary>
        /// FFSBLT.
        /// </summary>
        public const string FFSBLT = "FFSBLT";

        /// <summary>
        /// FFSBL.
        /// </summary>
        public const string FFSBL = "FFSBL";

        /// <summary>
        /// FFEFTB.
        /// </summary>
        public const string FFEFTB = "FFEFTB";

        /// <summary>
        /// FFEFTE.
        /// </summary>
        public const string FFEFTE = "FFEFTE";
    }

    /// <inheritdoc />
    public override string TableName => "F12003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FFCO", "FFCO", JdeDataType.String, 10, true, true),
        new JdeField("FFDAOB", "FFDAOB", JdeDataType.String, 12, true, true),
        new JdeField("FFDASB", "FFDASB", JdeDataType.String, 16, true, true),
        new JdeField("FFLT", "FFLT", JdeDataType.String, 4, true, true),
        new JdeField("FFADM", "FFADM", JdeDataType.String, 4),
        new JdeField("FFADLM", "FFADLM", JdeDataType.Numeric),
        new JdeField("FFITAC", "FFITAC", JdeDataType.String, 2),
        new JdeField("FFADMP", "FFADMP", JdeDataType.Numeric),
        new JdeField("FFADSN", "FFADSN", JdeDataType.String, 24),
        new JdeField("FFDIR1", "FFDIR1", JdeDataType.String, 2),
        new JdeField("FFLCT", "FFLCT", JdeDataType.Numeric),
        new JdeField("FFUSER", "FFUSER", JdeDataType.String, 20),
        new JdeField("FFPID", "FFPID", JdeDataType.String, 20),
        new JdeField("FFUPMJ", "FFUPMJ", JdeDataType.Numeric),
        new JdeField("FFJOBN", "FFJOBN", JdeDataType.String, 20),
        new JdeField("FFUPMT", "FFUPMT", JdeDataType.Numeric),
        new JdeField("FFACL1", "FFACL1", JdeDataType.String, 6),
        new JdeField("FFADC", "FFADC", JdeDataType.String, 6),
        new JdeField("FFSBLT", "FFSBLT", JdeDataType.String, 2),
        new JdeField("FFSBL", "FFSBL", JdeDataType.String, 16),
        new JdeField("FFEFTB", "FFEFTB", JdeDataType.Numeric),
        new JdeField("FFEFTE", "FFEFTE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F12003_0", "Primary Key on FFCO, FFDAOB, FFDASB, FFLT", new[] { "FFCO", "FFDAOB", "FFDASB", "FFLT" }, isUnique: true, isPrimaryKey: true)
    };
}
