using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42X040W - .
/// </summary>
public class F42X040W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GRSNKY.
        /// </summary>
        public const string GRSNKY = "GRSNKY";

        /// <summary>
        /// GRPRGR.
        /// </summary>
        public const string GRPRGR = "GRPRGR";

        /// <summary>
        /// GROLVL.
        /// </summary>
        public const string GROLVL = "GROLVL";

        /// <summary>
        /// GRTOQN.
        /// </summary>
        public const string GRTOQN = "GRTOQN";

        /// <summary>
        /// GRTOWT.
        /// </summary>
        public const string GRTOWT = "GRTOWT";

        /// <summary>
        /// GRTOSA.
        /// </summary>
        public const string GRTOSA = "GRTOSA";

        /// <summary>
        /// GRFAP.
        /// </summary>
        public const string GRFAP = "GRFAP";

        /// <summary>
        /// GRCRCD.
        /// </summary>
        public const string GRCRCD = "GRCRCD";

        /// <summary>
        /// GRPEFJ.
        /// </summary>
        public const string GRPEFJ = "GRPEFJ";

        /// <summary>
        /// GRITM.
        /// </summary>
        public const string GRITM = "GRITM";

        /// <summary>
        /// GRMCU.
        /// </summary>
        public const string GRMCU = "GRMCU";

        /// <summary>
        /// GRSHAN.
        /// </summary>
        public const string GRSHAN = "GRSHAN";

        /// <summary>
        /// GRUOM.
        /// </summary>
        public const string GRUOM = "GRUOM";

        /// <summary>
        /// GRWTUM.
        /// </summary>
        public const string GRWTUM = "GRWTUM";

        /// <summary>
        /// GRUOM1.
        /// </summary>
        public const string GRUOM1 = "GRUOM1";

        /// <summary>
        /// GRUOM2.
        /// </summary>
        public const string GRUOM2 = "GRUOM2";

        /// <summary>
        /// GR42XPROC.
        /// </summary>
        public const string GR42XPROC = "GR42XPROC";

        /// <summary>
        /// GRKCOO.
        /// </summary>
        public const string GRKCOO = "GRKCOO";

        /// <summary>
        /// GRUSER.
        /// </summary>
        public const string GRUSER = "GRUSER";

        /// <summary>
        /// GRPID.
        /// </summary>
        public const string GRPID = "GRPID";

        /// <summary>
        /// GRJOBN.
        /// </summary>
        public const string GRJOBN = "GRJOBN";

        /// <summary>
        /// GRUPMJ.
        /// </summary>
        public const string GRUPMJ = "GRUPMJ";

        /// <summary>
        /// GRUOM4.
        /// </summary>
        public const string GRUOM4 = "GRUOM4";

        /// <summary>
        /// GRUPMT.
        /// </summary>
        public const string GRUPMT = "GRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F42X040W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GRSNKY", "GRSNKY", JdeDataType.String, 64, true, true),
        new JdeField("GRPRGR", "GRPRGR", JdeDataType.String, 16, true, true),
        new JdeField("GROLVL", "GROLVL", JdeDataType.String, 2, true, true),
        new JdeField("GRTOQN", "GRTOQN", JdeDataType.Numeric),
        new JdeField("GRTOWT", "GRTOWT", JdeDataType.Numeric),
        new JdeField("GRTOSA", "GRTOSA", JdeDataType.Numeric),
        new JdeField("GRFAP", "GRFAP", JdeDataType.Numeric),
        new JdeField("GRCRCD", "GRCRCD", JdeDataType.String, 6),
        new JdeField("GRPEFJ", "GRPEFJ", JdeDataType.Numeric),
        new JdeField("GRITM", "GRITM", JdeDataType.Numeric),
        new JdeField("GRMCU", "GRMCU", JdeDataType.String, 24),
        new JdeField("GRSHAN", "GRSHAN", JdeDataType.Numeric),
        new JdeField("GRUOM", "GRUOM", JdeDataType.String, 4),
        new JdeField("GRWTUM", "GRWTUM", JdeDataType.String, 4),
        new JdeField("GRUOM1", "GRUOM1", JdeDataType.String, 4),
        new JdeField("GRUOM2", "GRUOM2", JdeDataType.String, 4),
        new JdeField("GR42XPROC", "GR42XPROC", JdeDataType.String, 2),
        new JdeField("GRKCOO", "GRKCOO", JdeDataType.String, 10),
        new JdeField("GRUSER", "GRUSER", JdeDataType.String, 20),
        new JdeField("GRPID", "GRPID", JdeDataType.String, 20),
        new JdeField("GRJOBN", "GRJOBN", JdeDataType.String, 20),
        new JdeField("GRUPMJ", "GRUPMJ", JdeDataType.Numeric),
        new JdeField("GRUOM4", "GRUOM4", JdeDataType.String, 4),
        new JdeField("GRUPMT", "GRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42X040W_0", "Primary Key on GRSNKY, GRPRGR, GROLVL", new[] { "GRSNKY", "GRPRGR", "GROLVL" }, isUnique: true, isPrimaryKey: true)
    };
}
