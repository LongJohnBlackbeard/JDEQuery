using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1549 - .
/// </summary>
public class F1549 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OLMCUS.
        /// </summary>
        public const string OLMCUS = "OLMCUS";

        /// <summary>
        /// OLMCU.
        /// </summary>
        public const string OLMCU = "OLMCU";

        /// <summary>
        /// OLULI.
        /// </summary>
        public const string OLULI = "OLULI";

        /// <summary>
        /// OLLNID.
        /// </summary>
        public const string OLLNID = "OLLNID";

        /// <summary>
        /// OLMCU2.
        /// </summary>
        public const string OLMCU2 = "OLMCU2";

        /// <summary>
        /// OLULI2.
        /// </summary>
        public const string OLULI2 = "OLULI2";

        /// <summary>
        /// OLNUMTEN.
        /// </summary>
        public const string OLNUMTEN = "OLNUMTEN";

        /// <summary>
        /// OLUSER.
        /// </summary>
        public const string OLUSER = "OLUSER";

        /// <summary>
        /// OLPID.
        /// </summary>
        public const string OLPID = "OLPID";

        /// <summary>
        /// OLJOBN.
        /// </summary>
        public const string OLJOBN = "OLJOBN";

        /// <summary>
        /// OLUPMJ.
        /// </summary>
        public const string OLUPMJ = "OLUPMJ";

        /// <summary>
        /// OLUPMT.
        /// </summary>
        public const string OLUPMT = "OLUPMT";

        /// <summary>
        /// OLTORG.
        /// </summary>
        public const string OLTORG = "OLTORG";

        /// <summary>
        /// OLENTJ.
        /// </summary>
        public const string OLENTJ = "OLENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1549";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OLMCUS", "OLMCUS", JdeDataType.String, 24, true, true),
        new JdeField("OLMCU", "OLMCU", JdeDataType.String, 24, true, true),
        new JdeField("OLULI", "OLULI", JdeDataType.String, 16, true, true),
        new JdeField("OLLNID", "OLLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("OLMCU2", "OLMCU2", JdeDataType.String, 24),
        new JdeField("OLULI2", "OLULI2", JdeDataType.String, 16),
        new JdeField("OLNUMTEN", "OLNUMTEN", JdeDataType.Numeric),
        new JdeField("OLUSER", "OLUSER", JdeDataType.String, 20),
        new JdeField("OLPID", "OLPID", JdeDataType.String, 20),
        new JdeField("OLJOBN", "OLJOBN", JdeDataType.String, 20),
        new JdeField("OLUPMJ", "OLUPMJ", JdeDataType.Numeric),
        new JdeField("OLUPMT", "OLUPMT", JdeDataType.Numeric),
        new JdeField("OLTORG", "OLTORG", JdeDataType.String, 20),
        new JdeField("OLENTJ", "OLENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1549_0", "Primary Key on OLMCUS, OLMCU, OLULI, OLLNID", new[] { "OLMCUS", "OLMCU", "OLULI", "OLLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
