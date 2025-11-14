using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F77100 - .
/// </summary>
public class F77100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J0YEID.
        /// </summary>
        public const string J0YEID = "J0YEID";

        /// <summary>
        /// J0TAXYR.
        /// </summary>
        public const string J0TAXYR = "J0TAXYR";

        /// <summary>
        /// J0VER.
        /// </summary>
        public const string J0VER = "J0VER";

        /// <summary>
        /// J0CO.
        /// </summary>
        public const string J0CO = "J0CO";

        /// <summary>
        /// J0TXIDS.
        /// </summary>
        public const string J0TXIDS = "J0TXIDS";

        /// <summary>
        /// J0WBT4.
        /// </summary>
        public const string J0WBT4 = "J0WBT4";

        /// <summary>
        /// J0WBR1.
        /// </summary>
        public const string J0WBR1 = "J0WBR1";

        /// <summary>
        /// J0WBT4A.
        /// </summary>
        public const string J0WBT4A = "J0WBT4A";

        /// <summary>
        /// J0WBR2.
        /// </summary>
        public const string J0WBR2 = "J0WBR2";

        /// <summary>
        /// J0WBNR4.
        /// </summary>
        public const string J0WBNR4 = "J0WBNR4";

        /// <summary>
        /// J0T4PRTS.
        /// </summary>
        public const string J0T4PRTS = "J0T4PRTS";

        /// <summary>
        /// J0REL1S.
        /// </summary>
        public const string J0REL1S = "J0REL1S";

        /// <summary>
        /// J0T4AS.
        /// </summary>
        public const string J0T4AS = "J0T4AS";

        /// <summary>
        /// J0RELS2.
        /// </summary>
        public const string J0RELS2 = "J0RELS2";

        /// <summary>
        /// J0NR4S.
        /// </summary>
        public const string J0NR4S = "J0NR4S";

        /// <summary>
        /// J0MBT4.
        /// </summary>
        public const string J0MBT4 = "J0MBT4";

        /// <summary>
        /// J0MBR1.
        /// </summary>
        public const string J0MBR1 = "J0MBR1";

        /// <summary>
        /// J0MBT4A.
        /// </summary>
        public const string J0MBT4A = "J0MBT4A";

        /// <summary>
        /// J0MBR2.
        /// </summary>
        public const string J0MBR2 = "J0MBR2";

        /// <summary>
        /// J0MBNR4.
        /// </summary>
        public const string J0MBNR4 = "J0MBNR4";

        /// <summary>
        /// J0ART4.
        /// </summary>
        public const string J0ART4 = "J0ART4";

        /// <summary>
        /// J0ARR1.
        /// </summary>
        public const string J0ARR1 = "J0ARR1";

        /// <summary>
        /// J0ART4A.
        /// </summary>
        public const string J0ART4A = "J0ART4A";

        /// <summary>
        /// J0ARR2.
        /// </summary>
        public const string J0ARR2 = "J0ARR2";

        /// <summary>
        /// J0ARNR4.
        /// </summary>
        public const string J0ARNR4 = "J0ARNR4";

        /// <summary>
        /// J0ARCS.
        /// </summary>
        public const string J0ARCS = "J0ARCS";

        /// <summary>
        /// J0ADJRE.
        /// </summary>
        public const string J0ADJRE = "J0ADJRE";

        /// <summary>
        /// J0EEOM.
        /// </summary>
        public const string J0EEOM = "J0EEOM";

        /// <summary>
        /// J0PCCV.
        /// </summary>
        public const string J0PCCV = "J0PCCV";

        /// <summary>
        /// J0NRCT.
        /// </summary>
        public const string J0NRCT = "J0NRCT";

        /// <summary>
        /// J0ICC1.
        /// </summary>
        public const string J0ICC1 = "J0ICC1";

        /// <summary>
        /// J0CC1.
        /// </summary>
        public const string J0CC1 = "J0CC1";

        /// <summary>
        /// J0EXC1.
        /// </summary>
        public const string J0EXC1 = "J0EXC1";

        /// <summary>
        /// J0R2PR.
        /// </summary>
        public const string J0R2PR = "J0R2PR";

        /// <summary>
        /// J0UPMJ.
        /// </summary>
        public const string J0UPMJ = "J0UPMJ";

        /// <summary>
        /// J0UPMT.
        /// </summary>
        public const string J0UPMT = "J0UPMT";

        /// <summary>
        /// J0PID.
        /// </summary>
        public const string J0PID = "J0PID";

        /// <summary>
        /// J0JOBN.
        /// </summary>
        public const string J0JOBN = "J0JOBN";

        /// <summary>
        /// J0USER.
        /// </summary>
        public const string J0USER = "J0USER";
    }

    /// <inheritdoc />
    public override string TableName => "F77100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J0YEID", "J0YEID", JdeDataType.String, 20, true, true),
        new JdeField("J0TAXYR", "J0TAXYR", JdeDataType.Numeric, null, true, true),
        new JdeField("J0VER", "J0VER", JdeDataType.String, 20),
        new JdeField("J0CO", "J0CO", JdeDataType.String, 10),
        new JdeField("J0TXIDS", "J0TXIDS", JdeDataType.String, 2),
        new JdeField("J0WBT4", "J0WBT4", JdeDataType.String, 2),
        new JdeField("J0WBR1", "J0WBR1", JdeDataType.String, 2),
        new JdeField("J0WBT4A", "J0WBT4A", JdeDataType.String, 2),
        new JdeField("J0WBR2", "J0WBR2", JdeDataType.String, 2),
        new JdeField("J0WBNR4", "J0WBNR4", JdeDataType.String, 2),
        new JdeField("J0T4PRTS", "J0T4PRTS", JdeDataType.String, 2),
        new JdeField("J0REL1S", "J0REL1S", JdeDataType.String, 2),
        new JdeField("J0T4AS", "J0T4AS", JdeDataType.String, 2),
        new JdeField("J0RELS2", "J0RELS2", JdeDataType.String, 2),
        new JdeField("J0NR4S", "J0NR4S", JdeDataType.String, 2),
        new JdeField("J0MBT4", "J0MBT4", JdeDataType.String, 2),
        new JdeField("J0MBR1", "J0MBR1", JdeDataType.String, 2),
        new JdeField("J0MBT4A", "J0MBT4A", JdeDataType.String, 2),
        new JdeField("J0MBR2", "J0MBR2", JdeDataType.String, 2),
        new JdeField("J0MBNR4", "J0MBNR4", JdeDataType.String, 2),
        new JdeField("J0ART4", "J0ART4", JdeDataType.String, 2),
        new JdeField("J0ARR1", "J0ARR1", JdeDataType.String, 2),
        new JdeField("J0ART4A", "J0ART4A", JdeDataType.String, 2),
        new JdeField("J0ARR2", "J0ARR2", JdeDataType.String, 2),
        new JdeField("J0ARNR4", "J0ARNR4", JdeDataType.String, 2),
        new JdeField("J0ARCS", "J0ARCS", JdeDataType.String, 2),
        new JdeField("J0ADJRE", "J0ADJRE", JdeDataType.String, 2),
        new JdeField("J0EEOM", "J0EEOM", JdeDataType.String, 4),
        new JdeField("J0PCCV", "J0PCCV", JdeDataType.String, 20),
        new JdeField("J0NRCT", "J0NRCT", JdeDataType.String, 2),
        new JdeField("J0ICC1", "J0ICC1", JdeDataType.String, 20),
        new JdeField("J0CC1", "J0CC1", JdeDataType.String, 6),
        new JdeField("J0EXC1", "J0EXC1", JdeDataType.String, 6),
        new JdeField("J0R2PR", "J0R2PR", JdeDataType.String, 20),
        new JdeField("J0UPMJ", "J0UPMJ", JdeDataType.Numeric),
        new JdeField("J0UPMT", "J0UPMT", JdeDataType.Numeric),
        new JdeField("J0PID", "J0PID", JdeDataType.String, 20),
        new JdeField("J0JOBN", "J0JOBN", JdeDataType.String, 20),
        new JdeField("J0USER", "J0USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F77100_0", "Primary Key on J0YEID, J0TAXYR", new[] { "J0YEID", "J0TAXYR" }, isUnique: true, isPrimaryKey: true)
    };
}
